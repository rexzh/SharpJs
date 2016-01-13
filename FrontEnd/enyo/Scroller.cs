using JavaScript;
using JavaScript.Html.DOM;

namespace enyo
{
    public class Scroller : Control
    {
        public EnyoEventHandler<Control, EnyoEventArgs> OnScrollStart;
        public EnyoEventHandler<Control, EnyoEventArgs> OnScrollStop;
        public EnyoEventHandler<Control, EnyoEventArgs> OnScroll;

        /// <summary>
        /// Returns an object describing the scroll boundaries with height and width properties.
        /// </summary>
        /// <returns></returns>
        public RectBound GetScrollBounds() { return null; }

        /// <summary>
        /// If true, the scroller will not propagate dragstart events that cause it to start scrolling. (Defaults to true.)
        /// </summary>
        public bool PreventDragPropagation;

        /// <summary>
        /// If true, the scroller will not propagate scroll events.
        /// </summary>
        public bool PreventScrollPropagation;

        /// <summary>
        /// Specifies how to horizontally scroll. Acceptable values are "scroll", "auto," "hidden," and "default". The precise effect of the setting is determined by the scroll strategy.
        /// </summary>
        public ScrollValue Horizontal { get; set; }

        /// <summary>
        /// Specifies how to vertically scroll. Acceptable values are "scroll", "auto," "hidden," and "default". The precise effect of the setting is determined by the scroll strategy.
        /// </summary>
        public ScrollValue Vertical { get; set; }

        /// <summary>
        /// Sets the vertical scroll position.
        /// </summary>
        public int ScrollTop { get; set; }

        /// <summary>
        /// Sets the horizontal scroll position.
        /// </summary>
        public int ScrollLeft { get; set; }

        /// <summary>
        /// Sets the maximum height of the scroll content.
        /// </summary>
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Set to true to make this scroller select a platform-appropriate touch-based scrolling strategy.
        /// Please note that specifycing a scrollStrategy will take precedence over this setting.
        /// </summary>
        public bool Touch { get; set; }

        /// <summary>
        /// Specifies a type of scrolling. The Enyo Scroller will attempt to automatically select a strategy compatible with the runtime environment. 
        /// A specific strategy may also be chosen:
        /// <para>ScrollStrategy is the default and implements no scrolling, relying instead on the environment to scroll properly.</para>
        /// <para>TouchScrollStrategy implements a touch scrolling mechanism.</para>
        /// <para>TranslateScrollStrategy implements a touch scrolling mechanism using translations; it is currently recommended only for Android 3 and 4.</para>
        /// </summary>
        public StrategyKind StrategyKind { get; set; }

        /// <summary>
        /// Set to true to display a scroll thumb in Touch scrollers.
        /// </summary>
        public bool Thumb { get; set; }

        /// <summary>
        /// Scrolls the given control (ctrl) into view. If alignWithTop is true, ctrl is aligned with the top of the scroller.
        /// </summary>
        /// <param name="ctrlm"></param>
        /// <param name="alignWithTop"></param>
        public void ScrollIntoView(Control ctrl, bool alignWithTop) { }

        /// <summary>
        /// Scrolls to the position specified by x and y in pixel units.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ScrollTo(int x, int y) { }

        public void ScrollToBottom() { }

        /// <summary>
        /// Ensures that the given control is visible in the scroller's viewport. Unlike scrollIntoView, which uses DOM's scrollIntoView, this only affects the current scroller.
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="alignWithTop"></param>
        public void ScrollToControl(Control ctrl, bool alignWithTop) { }

        public void ScrollToLeft() { }

        public void ScrollToNode(HtmlElement node, bool slignWithTop) { }

        public void ScrollToRight() { }

        public void ScrollToTop() { }

        /// <summary>
        /// If true and a touch scroller, the scroller will overscroll and bounce back at the edges (Defaults to true.)
        /// </summary>
        public bool TouchOverscroll;

    }
}
