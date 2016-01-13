using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using SJC.Artifacts;

namespace SJC.Compiler
{
    //Note: Used for Integrate with MSBuild
    public class Sjc : Task
    {
        private string _csprojPath;

        [Required]
        public string CsprojPath
        {
            get { return _csprojPath; }
            set
            {
                _csprojPath = value;
                if (!File.Exists(_csprojPath))
                {
                    throw new System.IO.FileNotFoundException("csproj file not found.", _csprojPath);
                }
            }
        }

        private string _build;
        [Required]
        public string Build
        {
            get { return _build; }
            set { _build = value; }
        }

        private bool _singleFile;
        public bool SingleFile
        {
            get { return _singleFile; }
            set { _singleFile = value; }
        }

        private string _supressWarnings = string.Empty;
        public string SupressWarnings
        {
            get { return _supressWarnings; }
            set { _supressWarnings = value; }
        }

        public override bool Execute()
        {
            CompileEngine engine = new CompileEngine();
            CompileOptions options = new CompileOptions(_singleFile ? ArtifactsType.SingleFile : ArtifactsType.MultipleFile, _build);
            engine.InitializeCompiler(this._csprojPath, options, _supressWarnings);

            var watch = Stopwatch.StartNew();
            var issues = engine.Compile();
            watch.Stop();
            Log.LogMessage(" {0} Compile done in {1} ms.", Constants.SharpJs, watch.ElapsedMilliseconds);

            foreach (var issue in issues.Issues)
            {
                var loc = issue.Location;
                string code = string.Format("{0}-{1}", Constants.SharpJs, issue.IssueId.ToString("0000"));
                switch (issue.IssueType)
                {
                    case IssueType.Warning:
                        Log.LogWarning(Constants.SharpJs, code, null, loc.FileName, loc.Line, loc.Column, loc.EndLine, loc.EndColumn, issue.Message);
                        break;

                    case IssueType.Error:
                        Log.LogError(Constants.SharpJs, code, null, loc.FileName, loc.Line, loc.Column, loc.EndLine, loc.EndColumn, issue.Message);
                        break;
                }
            }

            return !issues.HasError;
        }
    }
}
