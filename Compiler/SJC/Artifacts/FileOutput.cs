using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class FileOutput : Output
    {
        private StreamWriter _w;
        public FileOutput(string path)
        {
            _w = new StreamWriter(path, false, Encoding.ASCII);
        }

        public override void Flush()
        {
            _w.Flush();
        }

        public override void WriteContent(char ch)
        {
            _w.Write(ch);
        }

        public override void WriteContent(string str)
        {
            _w.Write(str);
        }

        #region IDisposable Support
        private bool _disposed = false;
        public override void Dispose()
        {
            if (!_disposed)
            {
                _w.Flush();
                _w.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
