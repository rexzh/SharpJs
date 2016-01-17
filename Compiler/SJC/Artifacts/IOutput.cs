using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    public interface IOutput : IDisposable
    {
        void IncreaseIndent();
        void DecreaseIndent();
        void ResetIndent();

        int IndentLevel { get; }

        Position Write(char ch);
        Position Write(String str);
        Position Write(String fmt, params object[] args);
        Position WriteLine();
        Position WriteLine(char ch);
        Position WriteLine(String str);
        Position WriteLine(String fmt, params object[] args);

        void Flush();
    }
}
