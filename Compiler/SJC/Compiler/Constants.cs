using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RexToy;

namespace SJC.Compiler
{
    class Constants
    {
        public const string SharpJs = "#JSC";

        public static string GetVersion()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string[] strArr = assembly.FullName.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in strArr)
            {
                var pair = str.Split('=');
                if (pair.Length == 2 && pair[0].Trim() == "Version")
                    return pair[1].Trim();
            }
            return string.Empty;
        }
    }
}
