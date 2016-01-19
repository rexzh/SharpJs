using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    public enum ArtifactsType
    {
        SingleFile,
        MultipleFile,
        Console
    }

    public static class ArtifactsFactory
    {
        public const string SrcMapRefLine = "//# sourceMappingURL=./{0}.map";
        public const string ConsoleJs = "console.js";
        public const string JavaScriptFileExtension = ".js";
        public const string CSharpFileExtension = ".cs";
        public const string SourceMapFileExtension = ".map";

        public static IArtifacts Create(ArtifactsType artifactsType, string outputDir, string outputFile, IndentType indentType = IndentType.Space4)
        {
            switch (artifactsType)
            {
                case ArtifactsType.SingleFile:
                    return new SingleFileArtifacts(outputDir, outputFile);

                case ArtifactsType.MultipleFile:
                    return new MultipleFileArtifacts(outputDir);

                default:
                    return new ConsoleArtifacts();
            }
        }
    }
}
