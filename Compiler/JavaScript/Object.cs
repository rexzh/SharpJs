using System;
using System.Collections;
using System.Collections.Generic;

namespace JavaScript
{
    [RenameClass("Object")]
    public class Object : IEnumerable<string>
    {
        [NonScript]
        public override int GetHashCode()
        {
            return 0;
        }

        [NonScript]
        public virtual bool Equals(Object that)
        {
            return false;
        }

        [NonScript]
        public virtual IEnumerator<string> GetEnumerator()
        {
            return null;
        }

        //Note: this is for js dynamic access
        public object this[string propertyName]
        {
            get { return null; }
            set { }
        }

        public bool HasOwnProperty(string propertyName)
        {
            return false;
        }

        public static Object Prototype;

        [NonScript]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}