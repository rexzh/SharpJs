using JavaScript;

namespace onyx
{
    /// <summary>
    /// A contextual popup is meant to be used in conjunction with a decorator, such as an onyx.MenuDecorator. The decorator couples the popup with an activating control, which may be a button or any other control with an onActivate event. When the control is activated, the popup shows itself in the correct position relative to the activator.
    /// </summary>
    public class ContextualPopup : enyo.Popup
    {
        /// <summary>
        /// Maximum height of the menu
        /// </summary>
        public int MaxHeight { get; set; }

        /// <summary>
        /// Toggle scrolling
        /// </summary>
        public bool Scrolling { get; set; }

        /// <summary>
        /// Popup title content
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Buttons at bottom of popup
        /// </summary>
        public enyo.Button[] ActionButtons { get; set; }
    }
}
