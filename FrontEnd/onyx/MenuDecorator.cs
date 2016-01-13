using JavaScript;

namespace onyx
{
    /// <summary>
    /// A control that activates an onyx.Menu. It loosely couples the Menu with an activating control, which may be a button or any other control with an onActivate event.
    /// The decorator must surround both the activating control and the menu itself. When the control is activated, the menu shows itself in the correct position relative to the activator.
    /// </summary>
    public class MenuDecorator : TooltipDecorator
    {
    }
}
