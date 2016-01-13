using System;

namespace enyo
{
    public class Layout
    {
        public static implicit operator Layout(string val)
        {
            return null;
        }

        public string LayoutClass;
    }
}
