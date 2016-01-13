using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// onyx.FlyweightPicker, a subkind of onyx.Picker, is a picker that employs the flyweight pattern. It is used to display a large list of selectable items. As with enyo.FlyweightRepeater, the onSetupItem event allows for customization of item rendering.
    /// To initialize the FlyweightPicker to a particular value, call setSelected with the index of the item you wish to select, and call setContent with the item that should be shown in the activator button.
    /// FlyweightPicker will send an onSelect event with a selected item's information. This can be received by a client application to determine which item was selected.
    /// </summary>
    public class FlyweightPicker
    {
        /// <summary>
        /// Sends the row index, and the row control, for decoration.
        /// </summary>
        public EnyoEventHandler<Control, SetupRowEventArgs> OnSetupItem;

        public EnyoEventHandler<Control, EnyoEventArgs> OnSelect;

        /// <summary>
        /// How many rows to render
        /// </summary>
        public int Count { get; set; }
    }
}
