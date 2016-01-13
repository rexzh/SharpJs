using JavaScript;
using JavaScript.Html.DOM;

namespace enyo
{
    /// <summary>
    /// Implements an HTML &lt;input&gt; element with cross-platform support for change events.
    /// </summary>
    public class Input : Control
    {
        /// <summary>
        /// Set to true to focus this control when it is rendered.
        /// </summary>
        public bool DefaultFocus;

        /// <summary>
        /// Sent when the input is disabled or enabled.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnDisabledChange;

        /// <summary>
        /// Value of the input. Use this property only to initialize the value. Use getValue() and setValue() to manipulate the value at runtime.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Text to display when the input is empty
        /// </summary>
        public string Placeholder { get; set; }

        public bool Disabled { get; set; }

        public InputType Type { get; set; }
    }
}
