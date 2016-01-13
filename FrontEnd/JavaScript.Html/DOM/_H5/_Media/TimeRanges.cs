using System;

namespace JavaScript.Html.DOM
{
    public abstract class TimeRanges
    {
        /// <summary>
        /// The number of ranges represented. Read only.
        /// </summary>
        public readonly ulong Length;

        /// <summary>
        /// Returns the time offset to the start of the specified time range.
        /// </summary>
        /// <param name="index">The index to the time range whose start time is to be returned.</param>
        /// <returns>The time at which the specified range starts, in seconds measured from the beginning of the timeline represented by the object.</returns>
        public float Start(ulong index)
        {
            return 0;
        }

        /// <summary>
        /// Returns the time offset to the end of the specified time range.
        /// </summary>
        /// <param name="index">The index to the time range whose end time is to be returned.</param>
        /// <returns>The time at which the specified range ends, in seconds measured from the beginning of the timeline represented by the object.</returns>
        public float End(ulong index)
        {
            return 0;
        }
    }
}
