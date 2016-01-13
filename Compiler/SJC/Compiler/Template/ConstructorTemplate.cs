using System;

namespace SJC.Compiler.Template
{
    class ConstructorTemplate : BasicMethodTemplate
    {
        public new const string ARGS = "args";

        public ConstructorTemplate(string begin, string end)
            : base(begin, end)
        {
        }
    }
}
