using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    sealed class SourceMapConsoleOutput : SourceMapOutput
    {
        public SourceMapConsoleOutput(string outputFileName) : base(outputFileName)
        {

        }

        public override void Dispose()
        {
            Flush();
        }

        protected override void Write(string str)
        {
            System.Console.Write(str);
        }

        protected override void WriteLine(string str)
        {
            System.Console.WriteLine(str);
        }
    }
}
