using JavaScript;

namespace onyx
{
    /// <summary>
    /// onyx.Picker, a subkind of onyx.Menu, is used to display a list of items that can be selected.
    /// It is meant to be used in conjunction with an onyx.PickerDecorator.
    /// The decorator loosely couples the Picker with an onyx.PickerButton--a button that, when tapped, shows the picker.
    /// Once an item is selected, the list of items closes, but the item stays selected and the PickerButton displays the choice that was made.
    /// </summary>
    public class Picker : Menu
    {
        public MenuItem Selected { get; set; }
        /// <summary>
        /// e.g. "200px"
        /// </summary>
        public string MaxHeight { get; set; }

        //scrollerName: "client"
        public void ScrollToSelected()
        {
        }
    }
}
