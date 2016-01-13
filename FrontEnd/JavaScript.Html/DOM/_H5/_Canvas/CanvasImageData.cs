using System;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasImageData
    {
        public readonly ulong Width;
        public readonly ulong Height;

        /// <summary>
        ///  one-dimensional array containing the data in RGBA order, as integers in the range 0 to 255
        /// </summary>
        public readonly byte[] data;
    }
}
