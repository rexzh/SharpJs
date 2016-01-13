using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
    public class RenameClassAttribute : Attribute
    {
        private string _className;
        public string ClassName
        {
            get { return _className; }
        }

        public RenameClassAttribute(string name)
        {
            _className = name;
        }
    }
}
