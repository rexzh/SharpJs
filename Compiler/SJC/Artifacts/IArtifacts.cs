using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    public interface IArtifacts : IDisposable
    {
        bool WriteWaterMark { get; set; }
        string WaterMark { get; set; }
        bool GenerateSourceMap { get; set; }
        void SwitchSource(string sourceFile);
        ArtifactOutput Output { get; }
    }
}
