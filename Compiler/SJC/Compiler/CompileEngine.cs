using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using RexToy;
using RexToy.Xml;

using SJC.Artifacts;

namespace SJC.Compiler
{
    public class CompileEngine
    {
        private CompileOptions _options;

        private string _startPath;
        private string _outputScript;
        private string _outputDir;

        private ErrorAggregator _aggregator;
        private CodeTemplate _template;

        private List<string> _refPathList = new List<string>();
        private List<string> _compilePathList = new List<string>();

        public void InitializeCompiler(string csprojPath, CompileOptions options = null, string supressWarnings = "")
        {
            _options = (options != null) ? options : CompileOptions.DEFAULT;

            _options.StdError.Information($"{Constants.SharpJs} compile: project: {Path.GetFileNameWithoutExtension(csprojPath)}, configuration: {options.ProjectConfig}", true);

            string[] numbers = supressWarnings.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var q = from n in numbers
                    select int.Parse(n);
            _aggregator = new ErrorAggregator(q);


            #region Parse C# project file
            _startPath = Path.GetDirectoryName(csprojPath);
            XDoc doc = XDoc.LoadFromFile(csprojPath);
            doc.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");

            _outputScript = doc.GetStringValue(@"x:PropertyGroup/x:AssemblyName") + ".js";


            var cfgList = doc.NavigateToList(@"x:PropertyGroup[@Condition]");
            bool configExist = false;
            foreach (var cfg in cfgList)
            {
                string condition = cfg.GetStringValue("@Condition");
                if (condition.Contains(options.ProjectConfig))
                {
                    var outpath = cfg.GetStringValue("x:OutputPath");
                    _outputDir = Path.Combine(_startPath, outpath);
                    configExist = true;
                    break;
                }
            }
            if (!configExist)
            {
                _aggregator.AppendIssue(CompileIssue.CreateNoLocationIssue(IssueType.Error, IssueId.BuildConfigError, options.ProjectConfig));
                return;
            }

            //Note:Project ref, get the assembly name and should be able to found under output
            var rl = doc.NavigateToList(@"x:ItemGroup/x:ProjectReference");
            foreach (var r in rl)
            {
                var refPrjPath = r.GetStringValue(@"@Include");
                XDoc xref = XDoc.LoadFromFile(Path.Combine(_startPath, refPrjPath));
                xref.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");
                var libName = xref.GetStringValue(@"x:PropertyGroup/x:AssemblyName");

                string assemblyPath = Path.GetFullPath(Path.Combine(_outputDir, libName + ".dll"));

                _refPathList.Add(assemblyPath);
                CheckAssembly(assemblyPath);
            }

            rl = doc.NavigateToList(@"x:ItemGroup/x:Reference");
            foreach (var r in rl)
            {
                string hint = r.GetStringValue(@"x:HintPath");
                if (!string.IsNullOrEmpty(hint))//Note: Add external assembly.
                {
                    string assemblyPath = Path.GetFullPath(Path.Combine(_startPath, hint));
                    _refPathList.Add(assemblyPath);
                    if (!CheckAssembly(assemblyPath))
                    {
                        var issue = CompileIssue.CreateNoLocationIssue(IssueType.Warning, IssueId.InvalidAssembly, assemblyPath);
                        _aggregator.AppendIssue(issue);
                    }
                }
            }

            //Note:Item to be compiled.
            var cl = doc.NavigateToList(@"x:ItemGroup/x:Compile");
            foreach (var c in cl)
            {
                string path = c.GetStringValue("@Include");
                if (path == @"Properties\AssemblyInfo.cs")
                    continue;
                _compilePathList.Add(Path.Combine(_startPath, path));
            }

            _template = CodeTemplate.Parse(Path.Combine(_startPath, @"Properties\template.xml"));
            #endregion
        }


        private bool CheckAssembly(string path)
        {
            Assembly assembly = Assembly.LoadFrom(path);
            var attrs = assembly.GetCustomAttributesData();
            foreach (var attr in attrs)
            {
                if (attr.AttributeType.FullName == typeof(JavaScript.ScriptAssemblyAttribute).FullName)
                {
                    return true;
                }
            }

            return false;
        }

        public ErrorAggregator Compile()
        {
            try
            {
                List<SyntaxTree> treeList = new List<SyntaxTree>();
                foreach (var f in _compilePathList)
                {
                    using (StreamReader r = new StreamReader(f))
                    {
                        SyntaxTree sTree = SyntaxFactory.ParseSyntaxTree(r.ReadToEnd(), null, f);
                        treeList.Add(sTree);
                    }
                }

                List<MetadataReference> references = new List<MetadataReference>();
                //Note: Std lib.
                //Extend: More lib? System.Core etc.
                references.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
                references.Add(MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location));

                foreach (string dir in _refPathList)
                {
                    var reference = MetadataReference.CreateFromFile(dir);
                    references.Add(reference);
                }

                var option = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
                var c = CSharpCompilation.Create(Constants.SharpJs, treeList, references, option);

                var trees = OrderResolver.Sort(c, _aggregator);

                GenerateArtifacts(trees, c);

                return _aggregator;
            }
            catch (Exception e)
            {
                CompileIssue issue = CompileIssue.CreateNoLocationIssue(IssueType.Error, IssueId.InternalError, e.Message);
                _aggregator.AppendIssue(issue);
                return _aggregator;
            }
        }

        private void GenerateArtifacts(IList<SyntaxTree> trees, Compilation c)
        {
            IArtifacts artifacts = ArtifactsFactory.Create(_options.ArtifactsType, _outputDir, _outputScript);
            artifacts.WriteWaterMark = _options.WriteWaterMark;
            artifacts.GenerateSourceMap = _options.GenerateSourceMap;

            artifacts.WaterMark = string.Format("//+++ This file is compiled by {0} {1} from C#. +++", Constants.SharpJs, Constants.GetVersion());

            foreach (SyntaxTree sourceTree in trees)
            {
                artifacts.SwitchSource(Path.GetFileNameWithoutExtension(sourceTree.FilePath));
                SemanticModel model = c.GetSemanticModel(sourceTree);

                Rewriter w = new Rewriter(model, _template, artifacts.Output, _aggregator);
                SyntaxNode newSource = w.Visit(sourceTree.GetRoot());
            }

            artifacts.Close();
        }
    }
}
