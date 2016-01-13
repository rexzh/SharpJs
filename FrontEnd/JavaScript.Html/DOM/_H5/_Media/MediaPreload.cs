using System;

namespace JavaScript.Html.DOM
{
    public abstract class MediaPreload
    {
        public static implicit operator MediaPreload(int val)
        {
            return null;
        }

        private MediaPreload() { }

        /// <summary>
        /// No data should be preloaded.
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";

        /// <summary>
        /// Only metadata should be preloaded.
        /// </summary>
        [EvalAtCompile]
        public const string MetaData = "metadata";

        /// <summary>
        /// The browser should preload whatever it thinks is reasonable, up to and including the entire media resource.
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";
    }
}
