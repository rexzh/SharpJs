using System;

namespace enyo
{
    /// <summary>
    /// enyo.PulldownList is a list that provides a pull-to-refresh feature, which allows new data to be retrieved and updated in the list.
    /// PulldownList provides the onPullRelease event to allow an application to start retrieving new data. The onPullComplete event indicates that the pull is complete and it's time to update the list with the new data.
    /// </summary>
    public class PulldownList : enyo.List
    {
        public EnyoEventHandler<PulldownList, EnyoEventArgs> onPullRelease;
        public EnyoEventHandler<PulldownList, EnyoEventArgs> onPullComplete;

        /// <summary>
        /// Signals that the list should execute pull completion. This is usually called after the application has received the new data.
        /// </summary>
        public void CompletePull()
        {
        }
    }
}
