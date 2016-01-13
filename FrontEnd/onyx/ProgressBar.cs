using enyo;

namespace onyx
{
    /// <summary>
    /// A control that shows the current progress of a process in a horizontal bar.
    /// </summary>
    public class ProgressBar : enyo.Control
    {
        public int Progress { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// The color of the bar can be customized by applying a background color to the bar via barClasses
        /// </summary>
        public string BarClasses { get; set; }
        public bool ShowStripes { get; set; }
        public bool AnimateStripes { get; set; }

        public EnyoEventHandler<Control, EnyoEventArgs> OnAnimateProgressFinish;

        /// <summary>
        /// Animate progress to the given value.
        /// </summary>
        /// <param name="val"></param>
        public void AnimateProgressTo(int val) { }
    }
}
