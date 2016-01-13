using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    class ConsoleOutput : Output
    {
        public ConsoleOutput(IndentType indentType = IndentType.Space4) : base(indentType)
        {
        }

        public override void WriteContent(string str)
        {
            System.Console.Write(str);
        }

        public override void WriteContent(char ch)
        {
            System.Console.Write(ch);
        }

        public override void Dispose()
        {
        }

        public override void Flush()
        {
        }
    }
}
