using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class GlobalVariableAttribute : Attribute
    {
    }
}
