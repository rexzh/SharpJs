using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// A control that presents a range of selection options in the form of a horizontal slider with a control knob that can be tapped and dragged to the desired location.
    /// </summary>
    public class Slider : ProgressBar
    {
        /// <summary>
        /// The onChange event is fired when the position is set, either by finishing a drag or by tapping the bar.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnChange;

        /// <summary>
        /// The onChanging event is fired when dragging the control knob.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnChanging;

        public EnyoEventHandler<Control, EnyoEventArgs> OnAnimateFinish;

        public int Value { get; set; }
        public bool LockBar { get; set; }
        public bool Tappable { get; set; }
    }
}
