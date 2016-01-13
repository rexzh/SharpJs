using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumValueAttribute : Attribute
    {
        public EnumValueAttribute(string val)
        {
        }
    }
}
