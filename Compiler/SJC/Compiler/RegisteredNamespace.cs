using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Compiler
{
    public class RegisteredNamespace
    {
        static List<string> _registered = new List<string>();

        public static bool Contains(string ns)
        {
            return _registered.Contains(ns);
        }

        public static void Add(string ns)
        {
            _registered.Add(ns);
        }
    }
}
