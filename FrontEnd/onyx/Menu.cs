using JavaScript;

namespace onyx
{
    /// <summary>
    /// onyx.Menu is a subkind of onyx.Popup that displays a list of onyx.MenuItems and looks like a popup menu.
    /// It is meant to be used in conjunction with an onyx.MenuDecorator.
    /// The decorator couples the menu with an activating control, which may be a button or any other control with an onActivate event. When the control is activated, the menu shows itself in the correct position relative to the activator.
    /// </summary>
    public class Menu : Popup
    {
        public bool ShowOnTop;
    }
}
