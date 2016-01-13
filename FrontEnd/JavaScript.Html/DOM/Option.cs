using System;

namespace JavaScript.Html.DOM
{
    [RenameClass("Option")]
    public class Option : HtmlElement
    {
        /// <summary>
        /// Sets or returns the index position of an option in a dropdown list
        /// </summary>
        public uint Index;

        /// <summary>
        /// Sets or returns the value of the selected attribute
        /// </summary>
        public bool Selected;

        /// <summary>
        /// Sets or returns the text of an option element
        /// </summary>
        public string Text;

        /// <summary>
        /// Sets or returns the value to be sent to the server
        /// </summary>
        public object Value;
    }
}
