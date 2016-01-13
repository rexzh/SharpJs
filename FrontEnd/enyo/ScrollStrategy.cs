using JavaScript;

namespace enyo
{
    /// <summary>
    /// enyo.ScrollStrategy is a helper kind that implements a default scrolling strategy for an enyo.Scroller.
    /// enyo.ScrollStrategy is not typically created in application code.
    /// </summary>
    public class ScrollStrategy : Control
    {
        protected ScrollStrategy() { }

        public ScrollValue Vertical { get; set; }
        public ScrollValue Horizontal { get; set; }

        public int ScrollLeft { get; set; }
        public int ScrollTop { get; set; }
        public int? MaxHeight { get; set; }
    }

    [NonScript]
    public class ScrollValue
    {
        private ScrollValue() { }

        public static implicit operator ScrollValue(string val)
        {
            return null;
        }

        /// <summary>
        /// Always shows a scrollbar; sets overflow: scroll.
        /// </summary>
        [EvalAtCompile]
        public const string Scroll = "scroll";

        /// <summary>
        /// Scrolls only if needed; sets overflow: auto.
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";

        /// <summary>
        /// Never scrolls; sets overflow: hidden.
        /// </summary>
        [EvalAtCompile]
        public const string Hidden = "hidden";

        /// <summary>
        /// Same as "auto".
        /// </summary>
        [EvalAtCompile]
        public const string Default = "default";
    }
}
