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

        void Write(char ch);
        void Write(String str);
        void Write(String fmt, params object[] args);
        void WriteLine();
        void WriteLine(String str);
        void WriteLine(String fmt, params object[] args);
        void WriteEmptyLine();

        void Flush();
    }
}
