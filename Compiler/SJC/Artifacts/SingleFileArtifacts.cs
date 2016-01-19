using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class SingleFileArtifacts : IArtifacts
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

        public SingleFileArtifacts(string outputDir, string outputFile)
        {
            string path = Path.Combine(outputDir, outputFile);
            _jsOutput = new JavaScriptFileOutput(path);

            _output = new ArtifactOutput();
            _output.JsOutput = _jsOutput;
        }

        public void Close()
        {
            this.Dispose();
        }

        public void SwitchSource(string sourceFile)
        {
            //TODO:
        }

        #region IDisposable Support
        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                if(GenerateSourceMap)
                {
                    //TODO:
                }
                if (this.WriteWaterMark)
                    this._jsOutput.WriteLine(WaterMark);
                _jsOutput.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
