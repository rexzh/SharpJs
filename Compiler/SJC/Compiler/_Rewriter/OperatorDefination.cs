using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Compiler
{
    public enum OperatorType
    {
        Unary,
        Binary,
        Unsupported
    }

    public class OperatorDefination
    {
        public string Token { get; set; }
        public OperatorType Type { get; set; }
        public bool Prefix { get; set; }
    }
}
