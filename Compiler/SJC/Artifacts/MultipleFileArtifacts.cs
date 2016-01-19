using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class MultipleFileArtifacts : IArtifacts
    {
        private IJavaScriptOutput _jsOutput;
        private string _outputDir;
        
        public bool GenerateSourceMap { get; set; }
        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }

        private ArtifactOutput _output;
        public ArtifactOutput Output
        {
            get { return _output; }
        }

        public MultipleFileArtifacts(string outputDir)
        {
            _outputDir = outputDir;

            _output = new ArtifactOutput();
        }

        public void SwitchSource(string sourceFile)
        {
            if (_jsOutput != null)
            {
                if(GenerateSourceMap)
                {
                    //TODO:
                }
                if (WriteWaterMark)
                    _jsOutput.WriteLine(WaterMark);
                _jsOutput.Flush();
                _jsOutput.Dispose();
            }
            string path = Path.Combine(_outputDir, sourceFile + ".js");
            _jsOutput = new JavaScriptFileOutput(path);
            _output.JsOutput = _jsOutput;
        }

        public void Close()
        {
            this.Dispose();
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
                if (WriteWaterMark)
                    this._jsOutput.WriteLine(WaterMark);
                _jsOutput.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
