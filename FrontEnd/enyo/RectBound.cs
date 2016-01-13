using System;

namespace enyo
{
    /// <summary>
    /// This class is used for multi purpose, not all the field is available in all case.
    /// </summary>
    public class RectBound
    {
        private RectBound() { }

        //Extend: each field can accept number (10, 100) or number with unit (10px, 5em)
        public int Top;
        public int Left;
        public uint Width;
        public uint Height;
        public int Right;
        public int Bottom;
    }
}
