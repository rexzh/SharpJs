using System;

namespace enyo
{
    /// <summary>
    /// enyo.Repeater is a simple control for making lists of items.
    /// Components of a repeater are copied for each item created, and are wrapped in a control that keeps the state of the item index.
    /// </summary>
    public class Repeater : Control
    {
        /// <summary>
        /// Be sure to return true from your onSetupItem handler to avoid having other event handlers further up the tree try to modify your item control.
        /// </summary>
        public EnyoEventHandler<Control, SetupRowEventArgs> OnSetupItem;

        /// <summary>
        /// Render the list
        /// </summary>
        public void Build() { }

        public int Count { get; set; }
    }
}
