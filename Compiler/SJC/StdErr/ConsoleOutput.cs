using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysConsole = System.Console;

using SJC.Console;

namespace SJC.StdErr
{
    public class ConsoleOutput : IOutput
    {
        private ConsoleOutput() { }
        public static readonly ConsoleOutput Instance = new ConsoleOutput();

        public string NormalPrompt { get; set; } = ">";

        public string KeyPrompt { get; set; } = "========";

        private string Prompt(bool keyInfo)
        {
            return keyInfo ? KeyPrompt : NormalPrompt;
        }

        public void Information(string msg, bool keyInfo)
        {
            SysConsole.WriteLine("{0}{1}", Prompt(keyInfo), msg);
        }

        public void Success(string msg, bool keyInfo)
        {
            ConsoleSettings.SetForeGroundColour(Console.ConsoleColor.Green);
            SysConsole.WriteLine("{0}{1}", Prompt(keyInfo), msg);
            ConsoleSettings.SetForeGroundColour();
        }

        public void Warning(string msg, bool keyInfo)
        {
            ConsoleSettings.SetForeGroundColour(Console.ConsoleColor.Yellow);
            SysConsole.WriteLine("{0}{1}", Prompt(keyInfo), msg);
            ConsoleSettings.SetForeGroundColour();
        }

        public void Error(string msg, bool keyInfo)
        {
            ConsoleSettings.SetForeGroundColour(Console.ConsoleColor.Red);
            SysConsole.WriteLine("{0}{1}", Prompt(keyInfo), msg);
            ConsoleSettings.SetForeGroundColour();
        }
    }
}
