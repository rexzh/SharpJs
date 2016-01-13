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
        public static IArtifacts Create(ArtifactsType artifactsType, string outputDir, string outputFile, IndentType indentType = IndentType.Space4)
        {
            switch(artifactsType)
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
