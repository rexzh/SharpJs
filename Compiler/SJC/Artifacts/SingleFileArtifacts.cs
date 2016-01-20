using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class SingleFileArtifacts : IArtifacts
    {
        public bool GenerateSourceMap { get; set; }
        public string WaterMark { get; set; }
        public bool WriteWaterMark { get; set; }

        private ArtifactOutput _output;
        public ArtifactOutput Output
        {
            get { return _output; }
        }

        private string _destPath;
        public SingleFileArtifacts(string outputDir, string outputFile)
        {
            _destPath = Path.Combine(outputDir, outputFile);

            _output = new ArtifactOutput();
            _output.JsOutput = new JavaScriptFileOutput(_destPath);
            _output.SourceMapOutput = new SourceMapFileOutput(_destPath + ArtifactsFactory.SourceMapFileExtension);
            _output.SourceMapOutput.File = outputFile;
        }

        public void SwitchSource(string sourceFileRelPath)
        {
            _output.SourceMapOutput.AddSource(sourceFileRelPath);
        }

        #region IDisposable Support
        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                if(GenerateSourceMap)
                {
                    this._output.TrivialWriteLine(string.Format(ArtifactsFactory.SrcMapRefLine, Path.GetFileName(_destPath)));
                }
                if (this.WriteWaterMark)
                    this._output.TrivialWriteLine(WaterMark);
                _output.Dispose();
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
