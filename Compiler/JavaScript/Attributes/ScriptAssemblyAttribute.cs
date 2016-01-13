using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    sealed public class ScriptAssemblyAttribute : Attribute
    {
    }
}
