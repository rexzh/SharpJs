using SJC.Console;

namespace SJC.Artifacts
{
    class ConsoleArtifacts : IArtifacts
    {
        public bool GenerateSourceMap { get; set; }
        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }

        private ArtifactOutput _output;
        public ArtifactOutput Output
        {
            get { return _output; }
        }

        public ConsoleArtifacts()
        {
            _output = new ArtifactOutput();
            _output.JsOutput = new JavaScriptConsoleOutput();
            _output.SourceMapOutput = new SourceMapConsoleOutput();
            _output.SourceMapOutput.File = ArtifactsFactory.ConsoleJs;
        }

        public void Dispose()
        {
            ConsoleSettings.SetForeGroundColour(ConsoleColor.Green, false);
            if (GenerateSourceMap)
            {
                _output.TrivialWriteLine(string.Format(ArtifactsFactory.SrcMapRefLine, ArtifactsFactory.ConsoleJs));
            }
            ConsoleSettings.SetForeGroundColour(ConsoleColor.Cyan, false);
            if (WriteWaterMark)
                _output.TrivialWriteLine(WaterMark);
            ConsoleSettings.SetForeGroundColour();

            _output.Dispose();
        }

        public void SwitchSource(string sourceFile)
        {
            _output.SourceMapOutput.AddSource(sourceFile + ArtifactsFactory.CSharpFileExtension);
        }
    }
}
