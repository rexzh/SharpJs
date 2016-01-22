using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class SourceMapFileOutput : SourceMapOutput
    {
        private StreamWriter _w;
        public SourceMapFileOutput(string path, string outputFileName) : base(outputFileName)
        {
            _w = new StreamWriter(path, false, Encoding.UTF8);
        }

        private bool _disposed = false;
        public override void Dispose()
        {
            if (!_disposed)
            {
                this.Flush();

                _w.Flush();
                _w.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        protected override void Write(string str)
        {
            _w.Write(str);
        }

        protected override void WriteLine(string str)
        {
            _w.WriteLine(str);
        }
    }
}
