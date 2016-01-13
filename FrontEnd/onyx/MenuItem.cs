using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// MenuItem is a button styled to look like a menu item, intended for use in an onyx.Menu. When the MenuItem is tapped, it tells the menu to hide itself and sends an onSelect event with its content and a reference to itself.
    /// </summary>
    public class MenuItem : enyo.Button
    {
        public EnyoEventHandler<Control, EnyoEventArgs> OnSelect;
    }
}
