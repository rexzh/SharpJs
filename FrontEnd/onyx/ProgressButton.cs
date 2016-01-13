using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// A progress bar that can have controls inside of it and has a cancel button on the right.
    /// </summary>
    public class ProgressButton : ProgressBar
    {
        public EnyoEventHandler<Control, EnyoEventArgs> OnCancel;
    }
}
