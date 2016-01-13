using System;

namespace JavaScript.Html.DOM
{
    public abstract class MediaError
    {
        /// <summary>
        /// Match with the constant define in this class
        /// </summary>
        public readonly int Code;

        /// <summary>
        /// User aborted video playback
        /// </summary>
        [EvalAtCompile]
        public const int MEDIA_ERR_ABORTED = 1;

        /// <summary>
        /// Network error (could not read the stream)
        /// </summary>
        [EvalAtCompile]
        public const int MEDIA_ERR_NETWORK = 2;

        /// <summary>
        /// Decoding error, video is broken or the codec makes problems
        /// </summary>
        [EvalAtCompile]
        public const int MEDIA_ERR_DECODE = 3;

        /// <summary>
        /// The format is not supported
        /// </summary>
        [EvalAtCompile]
        public const int MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
    }
}
