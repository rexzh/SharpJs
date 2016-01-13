using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class JsNativeAttribute : Attribute
    {
    }
}
