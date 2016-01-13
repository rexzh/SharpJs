using enyo;

namespace onyx
{
    /// <summary>
    /// A control that looks like a switch with labels for two states. Each time a ToggleButton is tapped, it switches its value and fires an onChange event.
    /// To find out the value of the button, use Value.
    /// The color of the toggle button can be customized by applying a background color:
    /// </summary>
    public class ToggleButton : enyo.Control
    {
        /// <summary>
        /// The onChange event fires when the user changes the value of the toggle button, but not when the value is changed programmatically.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnChange;

        public bool Active { get; set; }
        public bool Value { get; set; }
        public string OnContent { get; set; }
        public string OffContent { get; set; }
        public bool Disabled { get; set; }
    }
}
