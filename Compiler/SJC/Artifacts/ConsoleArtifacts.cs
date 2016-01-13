using SJC.Console;

namespace SJC.Artifacts
{
    class ConsoleArtifacts : IArtifacts
    {
        private IOutput _output;

        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }

        public ConsoleArtifacts()
        {
            _output = new ConsoleOutput();
        }

        public IOutput Output
        {
            get
            {
                return _output;
            }
        }

        public void Close()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            ConsoleSettings.SetForeGroundColour(ConsoleColor.Cyan, false);
            if (WriteWaterMark)
                _output.WriteLine(WaterMark);
            ConsoleSettings.SetForeGroundColour();
        }

        public void SwitchSource(string sourceFile)
        {
        }
    }
}
