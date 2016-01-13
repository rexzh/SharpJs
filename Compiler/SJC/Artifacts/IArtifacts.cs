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
        void SwitchSource(string sourceFile);
        IOutput Output { get; }
        void Close();
    }
}
