using JavaScript;

namespace onyx
{
    /// <summary>
    /// onyx.MoreToolbar is a kind of onyx.
    /// Toolbar that can adapt to different screen sizes by moving overflowing controls and content into an onyx.Menu
    /// A control can be forced to never move to the menu by setting the optional unmovable property to true (default is false).
    /// </summary>
    public class MoreToolbar : enyo.Control
    {
        /// <summary>
        /// style class to be applied to the menu
        /// </summary>
        public string MenuClass;

        /// <summary>
        /// style class to be applied to individual controls moved from the toolbar to the menu
        /// </summary>
        public string MovedClass;
    }
}
