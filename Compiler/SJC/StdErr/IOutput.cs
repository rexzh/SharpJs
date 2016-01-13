using System;
using System.Collections.Generic;
using System.Linq;

namespace SJC.StdErr
{
    public interface IOutput
    {
        string NormalPrompt { get; set; }
        string KeyPrompt { get; set; }
        void Success(string msg, bool keyInfo = false);
        void Information(string msg, bool keyInfo = false);
        void Warning(string msg, bool keyInfo = false);
        void Error(string msg, bool keyInfo = false);
    }
}
