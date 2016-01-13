using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = false)]
    public class RenameMemberAttribute : Attribute
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public RenameMemberAttribute(string name)
        {
            _name = name;
        }
    }
}
