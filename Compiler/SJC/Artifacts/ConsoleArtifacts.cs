using SJC.Console;

namespace SJC.Artifacts
{
    class ConsoleArtifacts : IArtifacts
    {
        private IJavaScriptOutput _jsOutput;

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
            _jsOutput = new JavaScriptConsoleOutput();

            _output = new ArtifactOutput();
            _output.JsOutput = _jsOutput;
        }

        public void Close()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            ConsoleSettings.SetForeGroundColour(ConsoleColor.Cyan, false);
            if(GenerateSourceMap)
            {
                //TODO:
            }
            if (WriteWaterMark)
                _jsOutput.WriteLine(WaterMark);
            ConsoleSettings.SetForeGroundColour();
        }

        public void SwitchSource(string sourceFile)
        {
            //TODO:
        }
    }
}
