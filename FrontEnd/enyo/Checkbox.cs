using System;

namespace enyo
{
    /// <summary>
    /// Implements an HTML checkbox input, with support for grouping.
    /// </summary>
    public class Checkbox : Input
    {
        public EnyoEventHandler<Control, EnyoEventArgs> OnActivate;

        /// <summary>
        /// Value of the checkbox
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// Group API requirement for determining selected item
        /// </summary>
        public bool Active { get; set; }
    }
}
