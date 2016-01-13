using System;

namespace JavaScript
{
    /// <summary>
    /// Mark on method etc that should not be called in Jscript. These methods exist for C#/.NET framework compatible
    /// </summary>    
    [NonScript]
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Delegate, AllowMultiple = false)]
    public class NonScriptAttribute : Attribute
    {
    }
}
