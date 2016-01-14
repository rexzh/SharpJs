using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class OperatorAttribute : Attribute
    {
        public OperatorAttribute(string token, int oprandNumber = 2, bool prefix = false)
        {
        }
    }
}
