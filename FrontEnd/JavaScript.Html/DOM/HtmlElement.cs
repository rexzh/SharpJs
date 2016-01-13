using System;

namespace JavaScript.Html.DOM
{
    public abstract class HtmlElement
    {
        /// <summary>
        /// Sets or returns the class attribute of an element
        /// </summary>
        public string ClassName;

        public readonly uint ScrollWidth;
        public readonly uint OffsetWidth;
        public readonly uint ScrollHeight;
        public readonly uint OffsetHeight;

        /// <summary>
        /// Returns the viewable height of the content on a page (not including borders, margins, or scrollbars)
        /// </summary>
        public readonly uint ClientHeight;

        /// <summary>
        /// Returns the viewable width of the content on a page (not including borders, margins, or scrollbars)
        /// </summary>
        public readonly uint ClientWidth;

        /// <summary>
        /// Sets or returns whether an element is disabled, or not
        /// </summary>
        public bool Disabled;

        /// <summary>
        /// Sets or returns the height attribute of an element
        /// </summary>
        public uint Height;

        /// <summary>
        /// Sets or returns the width attribute of an element
        /// </summary>
        public uint Width;

        /// <summary>
        /// Sets or returns the id of an element
        /// </summary>
        public string Id;

        /// <summary>
        /// Sets or returns the HTML contents (+text) of an element
        /// </summary>
        public string InnerHTML;

        /// <summary>
        /// Sets or returns the tab order of an element
        /// </summary>
        public uint TabIndex;

        /// <summary>
        /// CSS Style object
        /// </summary>
        public Style Style;

        /// <summary>
        /// data-* set
        /// </summary>
        public object Dataset;
        
        public HtmlElement AppendChild(HtmlElement element)
        {
            return null;
        }

        public HtmlElement RemoveChild(HtmlElement element)
        {
            return null;
        }

        /// <summary>
        /// Gives focus to an element
        /// </summary>
        public void Focus()
        {
        }

        /// <summary>
        /// Removes focus from an element
        /// </summary>
        public void Blur()
        {
        }

        /// <summary>
        /// Executes a click on an element
        /// </summary>
        public void Click()
        {
        }        
    }
}
