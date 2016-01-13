using System;

namespace SJC.Compiler.Template
{
    abstract class BasicFieldTemplate : AbstractTemplate
    {
        public const string FIELD = "field";

        protected BasicFieldTemplate(string begin, string end)
            : base(begin, end)
        {
        }
    }
}
