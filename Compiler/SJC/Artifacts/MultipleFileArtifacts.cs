using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class MultipleFileArtifacts : IArtifacts
    {
        private IOutput _output;
        private string _outputDir;

        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }
        public MultipleFileArtifacts(string outputDir)
        {
            _outputDir = outputDir;
        }

        public void SwitchSource(string sourceFile)
        {
            if (_output != null)
            {
                if (WriteWaterMark)
                    _output.WriteLine(WaterMark);
                _output.Flush();
                _output.Dispose();
            }
            string path = Path.Combine(_outputDir, sourceFile + ".js");
            _output = new FileOutput(path);
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

        #region IDisposable Support
        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                if (WriteWaterMark)
                    this._output.WriteLine(WaterMark);
                _output.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
