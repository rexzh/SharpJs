using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SJC.Artifacts;
using SJC.StdErr;

namespace SJC.Compiler
{
    public class CompileOptions
    {
        public const string DEBUG_ANY_CPU = "Debug|AnyCPU";
        public const string RELEASE_ANY_CPU = "Release|AnyCPU";

        public ArtifactsType ArtifactsType { get; } = ArtifactsType.MultipleFile;
        public string ProjectConfig { get; } = DEBUG_ANY_CPU;
        public bool WriteWaterMark { get; } = true;
        public StdErr.IOutput StdError { get; } = StdErr.ConsoleOutput.Instance;
        public bool GenerateSourceMap { get; set; } = false;
        public int IndentSpace { set; get; } = 4;

        public static CompileOptions DEFAULT = new CompileOptions();

        protected CompileOptions()
        {
        }

        public CompileOptions(ArtifactsType artifactsType, string config, bool writeWaterMark = true, StdErr.IOutput stderr = null)
        {
            this.ArtifactsType = artifactsType;
            this.ProjectConfig = config;
            this.WriteWaterMark = writeWaterMark;
            if (stderr != null)
                this.StdError = stderr;
        }
    }
}
