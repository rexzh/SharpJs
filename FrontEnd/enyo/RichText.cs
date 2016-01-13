using System;

namespace enyo
{
    /// <summary>
    /// A multi-line text input that supports rich formatting, such as bold, italics, and underlining.
    /// Use the value property to get or set the displayed text.
    /// RichText is not supported on Android &lt; 3.
    /// Selection operations and insertAtCursor use the HTML Editing APIs.
    /// </summary>
    public class RichText : Input
    {
        /// <summary>
        /// Returns true if the RichText is focused.
        /// </summary>
        /// <returns></returns>
        public bool HasFocus() { return false; }

        /// <summary>
        /// Inserts HTML at the cursor position. HTML is escaped unless the allowHTML property is true.
        /// </summary>
        /// <param name="val"></param>
        public void InsertAtCursor(string val) { }

        public void SelectAll() { }

        //TODO:To be implment HTML editing API
        /// <summary>
        /// Returns the selection object.
        /// </summary>
        /// <returns></returns>
        //public object GetSelection() { return null; } //return Html editing API
        /*
        modifySelection: function(inType, inDirection, inAmount)
        moveCursor: function(inDirection, inAmount)
        Moves the cursor according to the Editing API.

        moveCursorToEnd: function()
        moveCursorToStart: function()

        removeSelection: function(inStart)
         */

    }
}
