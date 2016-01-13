using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Parameter)]
    public class RenameParameterAttribute : Attribute
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public RenameParameterAttribute(string name)
        {
            _name = name;
        }
    }
}
