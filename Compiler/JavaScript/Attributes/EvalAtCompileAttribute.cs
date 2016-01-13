using System;

namespace JavaScript
{
    [NonScript]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EvalAtCompileAttribute : Attribute
    {
        private object _value;
        public object Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }
    }
}
