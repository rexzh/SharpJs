using System;
using JavaScript;
using JavaScript.Html.DOM;

namespace enyo
{
    /// <summary>
    /// A control that displays a repeating list of rows. It is suitable for displaying medium-sized lists (maximum of ~100 items). A flyweight strategy is employed to render one set of row controls as needed for as many rows as are contained in the repeater.
    /// <para>Controls inside a FlyweightRepeater are non-interactive. This means that outside the onSetupItem event, calling methods that would otherwise cause rendering to occur will not do so (e.g. setContent). A row can be forced to render by calling the renderRow(inRow) method. In addition, a row can be temporarily made interactive by calling the prepareRow(inRow) method. When interaction is complete, the lockRow method should be called.
    /// </para>
    /// </summary>
    public class FlyweightRepeater : Control
    {
        public bool BottomUp;

        /// <summary>
        /// Fired once per row at render-time, event object has additional selected property.
        /// </summary>
        public EnyoEventHandler<Control, SetupRowEventArgs> OnSetupItem;

        /// <summary>
        /// Fetch the dom node for the given row index.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public HtmlElement FetchRowNode(int idx) { return null; }

        public Selection GetSelection() { return null; }

        /// <summary>
        /// Get the selection state for the given row index.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool IsSelected(bool idx) { return false; }

        /// <summary>
        /// Prevent changes to the controls inside the repeater from being rendered
        /// </summary>
        public void LockRow() { }

        /// <summary>
        /// Prepare the row specified by inIndex such that changes effected on the controls in the row will be rendered in the given row; then perform the function func; finally lock the row.
        /// </summary>
        /// <param name="idx"></param>
        /// <param name="func"></param>
        /// <param name="context"></param>
        public void PerformOnRow(int idx, Delegate func, object context = null) { }

        /// <summary>
        /// Prepare the row specified by inIndex such that changes effected on the controls inside the repeater will be rendered for the given row.
        /// </summary>
        /// <param name="idx"></param>
        public void PrepareRow(int idx) { }

        /// <summary>
        /// How many rows to render
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// If true, allow multiple selections
        /// </summary>
        public bool MultiSelect { get; set; }

        /// <summary>
        /// If true, the selection mechanism is disabled. Tap events are still sent, but items won't be automatically re-rendered when tapped.
        /// </summary>
        public bool NoSelect { get; set; }

        /// <summary>
        /// If true, the selected item will toggle
        /// </summary>
        public bool ToggleSelected { get; set; }

        /// <summary>
        /// Render the row specified by inIndex.
        /// </summary>
        /// <param name="idx"></param>
        public void RenderRow(int idx)
        {
        }

        //Extend:Not expose
        //public int RowForEvent(DomEvent evt){return 0;}

        public int RowOffset;

    }
}
