using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

using RexToy;

using SJC.Artifacts;
using SJC.Console;
using SJC.Compiler;

namespace SJC
{
    class Program
    {
        private static string _csprojFile;
        private static string _config;
        private static string _suppressWarnings = string.Empty;
        private static bool _singleFile = true;
        private static bool _writeFile = true;
        private static bool _generateSourceMap = true;

        private static bool ExtractParams(string[] args)
        {
            foreach (var arg in args)
            {
                var idx = arg.IndexOf(":");
                if (idx < 0)
                {
                    return false;
                }
                string p = arg.Substring(0, idx);
                if (p == "p" || p == "-p")
                {
                    _csprojFile = arg.Substring(idx + 1);
                    continue;
                }
                if (p == "s" || p == "-s")
                {
                    _singleFile = bool.Parse(arg.Substring(idx + 1));
                    continue;
                }
                if (p == "w" || p == "-w")
                {
                    _writeFile = bool.Parse(arg.Substring(idx + 1));
                    continue;
                }
                if (p == "c" || p == "-c")
                {
                    _config = arg.Substring(idx + 1);
                    continue;
                }
                if (p == "i" || p == "-i")
                {
                    _suppressWarnings = arg.Substring(idx + 1);
                    continue;
                }
                if (p == "m" || p == "-m")
                {
                    _generateSourceMap = bool.Parse(arg.Substring(idx + 1));
                    continue;
                }
                return false;
            }
            if (string.IsNullOrEmpty(_csprojFile))
                return false;
            if (!File.Exists(_csprojFile))
            {
                System.Console.WriteLine("Project file not exist.");
                return false;
            }

            return true;
        }

        private static void ShowMessage()
        {
            System.Console.WriteLine("C# Cross Compiler, version [{0}]", Constants.GetVersion());
            System.Console.WriteLine("Usage: SJC -o:<output dir> -p:<csproj file> [-c:<Debug|Release>] [-s:<true|false>] [-w:<true|false>] [-q:<true|false>]");
            System.Console.WriteLine("     s: single file[default is true]");
            System.Console.WriteLine("     w: write to file(true write to file[which is default], false write to console).");
            System.Console.WriteLine("     i: supress cpmpile warning #.");
            System.Console.WriteLine("     c: Debug or Release (default is debug)");
            System.Console.WriteLine("     m: Generate Source Map");
            System.Console.WriteLine(@"    Example: -p:..\..\Sample\Sample.csproj");
            System.Console.WriteLine(@"Recommend usage, in VS project post-build event:");
            System.Console.WriteLine(@"    [Path]SJC -p:$(ProjectDir)$(ProjectFileName) -s:false -i:1029,1030");
        }

        static void Main(string[] args)
        {
            if (!ExtractParams(args))
            {
                ShowMessage();
                return;
            }
            else
            {
                CompileEngine engine = new CompileEngine();
                ArtifactsType artifactsType = ArtifactsType.Console;
                if (_writeFile)
                {
                    if (_singleFile)
                        artifactsType = ArtifactsType.SingleFile;
                    else
                        artifactsType = ArtifactsType.MultipleFile;
                }

                if ((!string.IsNullOrEmpty(_config)) && _config.ToUpper() == "RELEASE")
                    _config = CompileOptions.RELEASE_ANY_CPU;
                else
                    _config = CompileOptions.DEBUG_ANY_CPU;


                CompileOptions opts = new CompileOptions(artifactsType, _config);
                opts.GenerateSourceMap = _generateSourceMap;

                engine.InitializeCompiler(_csprojFile, opts, _suppressWarnings);
                var errors = engine.Compile();
                errors.WriteToStdErr(opts.StdError);
            }
            System.Console.ReadLine();
        }
    }
}
