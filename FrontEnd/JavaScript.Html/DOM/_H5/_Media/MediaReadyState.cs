using System;

namespace JavaScript.Html.DOM
{
    public abstract class MediaReadyState
    {
        public static implicit operator MediaReadyState(int val)
        {
            return null;
        }

        private MediaReadyState() { }

        /// <summary>
        /// No information is available about the media resource.
        /// </summary>
        [EvalAtCompile]
        public const int HAVE_NOTHING = 0;

        /// <summary>
        /// Enough of the media resource has been retrieved that the metadata attributes are initialized.
        /// </summary>
        [EvalAtCompile]
        public const int HAVE_METADATA = 1;

        /// <summary>
        /// Data is available for the current playback position, but not enough to actually play more than one frame.
        /// </summary>
        [EvalAtCompile]
        public const int HAVE_CURRENT_DATA = 2;

        /// <summary>
        /// Data for the current playback position as well as for at least a little bit of time into the future is available (in other words, at least two frames of video, for example).
        /// </summary>
        [EvalAtCompile]
        public const int HAVE_FUTURE_DATA = 3;

        /// <summary>
        /// Enough data is available—and the download rate is high enough—that the media can be played through to the end without interruption.
        /// </summary>
        [EvalAtCompile]
        public const int HAVE_ENOUGH_DATA = 4;
    }
}
