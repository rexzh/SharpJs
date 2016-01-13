using System;

namespace enyo
{
    /// <summary>
    /// A control that displays a scrolling list of rows.
    /// It is suitable for displaying very large lists.
    /// List is optimized such that only a small portion of the list is rendered at a given time.
    /// A flyweight pattern is employed such that the controls placed inside the list are created once but are rendered for each list item.
    /// For this reason, it's best to use only simple controls in an enyo.List like enyo.Control and enyo.Image.
    /// </summary>
    public class List : Scroller
    {
        /// <summary>
        /// Fired once per row at render-time
        /// </summary>
        public EnyoEventHandler<Control, SetupRowEventArgs> OnSetupItem;

        public int GetScrollPosition() { return 0; }
        public int SetScrollPosition(int pos) { return 0; }

        /// <summary>
        /// Returns the selection component (enyo.Selection) that manages the selection state for this list.
        /// </summary>
        /// <returns></returns>
        public Selection GetSelection() { return null; }

        /// <summary>
        /// Get the selection state for the given row index.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool IsSelected(int idx) { return false; }

        /// <summary>
        /// Restore the row to being non-interactive.
        /// </summary>
        public void LockRow() { }

        /// <summary>
        /// Perform a set of tasks by runnin the function func on a row that require it to be interactive when those tasks are performed. Lock the row when done.
        /// </summary>
        /// <param name="idx"></param>
        /// <param name="func"></param>
        /// <param name="context"></param>
        public void PerformOnRow(int idx, Delegate func, object context = null) { }

        /// <summary>
        /// Prepare the row to become interactive.
        /// </summary>
        /// <param name="idx"></param>
        public void PrepareRow(int idx) { }

        /// <summary>
        /// The number of rows contained in the list. Note, as the amount of list data changes setRows can be called to adjust the number of rows. To re-render the list at the current position when count has changed, call the refresh() method.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The number of rows to be shown on a given list page segment. It is not common to need to adjust this.
        /// </summary>
        public int RowsPerPage { get; set; }

        /// <summary>
        /// Render the list such that row 0 is at the bottom of the viewport and the beginning position of the list is scrolled to the bottom.
        /// </summary>
        public bool BottomUp { get; set; }

        /// <summary>
        /// If true, the selection mechanism is disabled. Tap events are still sent, but items won't be automatically re-rendered when tapped.
        /// </summary>
        public bool NoSelect { get; set; }

        /// <summary>
        /// If true, allow multiple selections
        /// </summary>
        public bool MultiSelect { get; set; }

        /// <summary>
        /// If true, the selected item will toggle
        /// </summary>
        public bool ToggleSelected { get; set; }

        /// <summary>
        /// If true, the list would assume all rows have the same height for optimization
        /// </summary>
        public bool FixedHeight { get; set; }

        /// <summary>
        /// Re-render the list at the current position
        /// </summary>
        public void Refresh() { }

        /// <summary>
        /// Re-render the specified row. Call after making modifications to the row to force it to render.
        /// </summary>
        /// <param name="idx"></param>
        public void RenderRow(int idx) { }

        /// <summary>
        /// Re-render the list from the beginning.
        /// </summary>
        public void Reset() { }

        /// <summary>
        /// Scrolls to the end of the list.
        /// </summary>
        public void ScrollToEnd() { }

        /// <summary>
        /// Scrolls to a specific row.
        /// </summary>
        public void ScrollToRow(int row) { }

        /// <summary>
        /// Scrolls to the beginning of the list.
        /// </summary>
        public void ScrollToStart() { }

        /// <summary>
        /// Set the selection state for the given row index.
        /// </summary>
        /// <param name="idx"></param>
        /// <param name="data"></param>
        public void Select(int idx, object data) { }
    }
}
