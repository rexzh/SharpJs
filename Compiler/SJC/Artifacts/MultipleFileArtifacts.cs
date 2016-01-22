using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class MultipleFileArtifacts : IArtifacts
    {
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

        private string _destPath;
        public void SwitchSource(string sourceFileRelPath)
        {
            if (_output.IsWriting)
            {
                if (GenerateSourceMap)
                {
                    _output.TrivialWriteLine(string.Format(ArtifactsFactory.SrcMapRefLine, Path.GetFileName(_destPath)));
                }
                if (WriteWaterMark)
                    _output.TrivialWriteLine(WaterMark);

                _output.CloseCurrentOutput();
            }
            string sourceFile = Path.GetFileNameWithoutExtension(sourceFileRelPath);
            _destPath = Path.Combine(_outputDir, sourceFile + ArtifactsFactory.JavaScriptFileExtension);
            _output.UseJavaScriptOutput(new JavaScriptFileOutput(_destPath));
            _output.UseSourceMapOutput(new SourceMapFileOutput(_destPath + ArtifactsFactory.SourceMapFileExtension, sourceFile + ArtifactsFactory.JavaScriptFileExtension));
            _output.AddSourceMap(sourceFile);
        }

        #region IDisposable Support
        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                if (GenerateSourceMap)
                {
                    _output.TrivialWriteLine(string.Format(ArtifactsFactory.SrcMapRefLine, Path.GetFileName(_destPath)));
                }
                if (WriteWaterMark)
                    this._output.TrivialWriteLine(WaterMark);
                _output.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
