using System;
namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
    public class ScriptDefaultValueAttribute : Attribute
    {
        public string Value { get; set; }
    }
}
