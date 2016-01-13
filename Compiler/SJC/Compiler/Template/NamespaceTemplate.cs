using System;

namespace SJC.Compiler.Template
{
    internal class NamespaceTemplate : AbstractTemplate
    {
        public const string NAMESPACE = "namespace";

        public NamespaceTemplate(string begin, string end)
            : base(begin, end)
        {
        }
    }
}
