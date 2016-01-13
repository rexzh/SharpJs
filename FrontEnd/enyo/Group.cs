using System;

namespace enyo
{
    /// <summary>
    /// enyo.Group provides a wrapper around multiple elements. It enables the creation of radio groups from arbitrary components supporting the GroupItem API.
    /// </summary>
    public class Group : Control
    {
        public bool Highlander { get; set; }

        /// <summary>
        /// The control that is selected
        /// </summary>
        public Control Active { get; set; }
    }
}
