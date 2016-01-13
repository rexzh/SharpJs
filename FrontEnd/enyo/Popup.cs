using System;

namespace enyo
{
    /// <summary>
    /// A popup is used to display content that should be displayed on top of other content.
    /// Popups are initially hidden on creation; they can be shown by calling the show method and re-hidden by calling hide. Popups may be centered using the centered property; if not centered, they should be given a specific position.
    /// A popup may be optionally floated above all application content by setting its floating property to true. This has the advantage of guaranteeing that the popup will be displayed on top of other content. This usage is appropriate when the popup does not need to scroll with other co
    /// The autoDismiss property controls how a popup may be dismissed. If true (the default), then tapping outside the popup or pressing the ESC key will dismiss the popup.
    /// </summary>
    public class Popup : Control
    {
        public EnyoEventHandler<Control, EnyoEventArgs> OnShow;
        public EnyoEventHandler<Control, EnyoEventArgs> OnHide;

        /// <summary>
        /// Set to true to prevent controls outside the popup from receiving events while the popup is showing.
        /// </summary>
        public bool Modal { get; set; }

        /// <summary>
        /// By default, the popup will hide when the user taps outside it or presses ESC. Set to false to prevent this behavior.
        /// </summary>
        public bool AutoDismiss { get; set; }

        /// <summary>
        /// If true, the popup will be rendered in a floating layer outside of other controls. This can be used to guarantee that the popup will be shown on top of other controls.
        /// </summary>
        public bool Floating { get; set; }

        /// <summary>
        /// Set to true to automatically center the popup in the middle of the viewport.
        /// </summary>
        public bool Centered { get; set; }

    }
}
