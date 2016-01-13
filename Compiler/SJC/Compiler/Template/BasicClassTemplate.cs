using System;

namespace SJC.Compiler.Template
{
    abstract class BasicClassTemplate : AbstractTemplate
    {
        public const string CLASS = "class";
        public const string BASECLASS = "baseclass";
        public const string INTERFACE = "interface";

        protected BasicClassTemplate(string begin, string end)
            : base(begin, end)
        {
        }
    }
}
