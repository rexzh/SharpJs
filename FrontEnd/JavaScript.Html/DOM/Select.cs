using System;

namespace JavaScript.Html.DOM
{
    [RenameClass("Select")]
    public class Select : HtmlElement
    {
        public Option[] Options;

        public int SelectedIndex;

        /// <summary>
        /// Returns the number of options in a dropdown list
        /// </summary>
        public readonly uint Length;

        /// <summary>
        /// Sets or returns the number of visible options in a dropdown list
        /// </summary>
        public uint Size;
    }
}
