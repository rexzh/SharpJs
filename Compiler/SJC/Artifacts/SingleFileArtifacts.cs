using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class SingleFileArtifacts : IArtifacts
    {
        private IOutput _output;
        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }

        public SingleFileArtifacts(string outputDir, string outputFile)
        {
            string path = Path.Combine(outputDir, outputFile);
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

        public void SwitchSource(string sourceFile)
        {
        }

        #region IDisposable Support
        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                if (this.WriteWaterMark)
                    this._output.WriteLine(WaterMark);
                _output.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
