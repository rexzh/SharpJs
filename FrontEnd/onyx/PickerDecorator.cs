using JavaScript;

namespace onyx
{
    /// <summary>
    /// A control that activates an onyx.Picker. 
    /// It loosely couples the Picker with an activating onyx.PickerButton. 
    /// The decorator must surround both the activating button and the picker itself. 
    /// When the button is activated, the picker shows itself in the correct position relative to the activator.
    /// </summary>
    public class PickerDecorator : MenuDecorator
    {
    }
}
