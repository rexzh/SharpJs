using System;

namespace SJC.Compiler.Template
{
    abstract class BasicMethodTemplate : AbstractTemplate
    {
        public const string METHOD = "method";
        public const string ARGS = "args";
        public const string CLASS = "class";

        protected BasicMethodTemplate(string begin, string end)
            : base(begin, end)
        {
        }
    }
}
