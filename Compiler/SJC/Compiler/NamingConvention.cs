using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Compiler
{
    static class NamingConvention
    {
        public static string LowerCase1stChar(this string name)
        {
            char c = name[0];
            char l = char.ToLower(c);
            return l + name.Substring(1);
        }
    }
}
