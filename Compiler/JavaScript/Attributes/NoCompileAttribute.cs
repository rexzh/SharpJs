using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Method)]
    public class NoCompileAttribute : Attribute
    {
    }
}
