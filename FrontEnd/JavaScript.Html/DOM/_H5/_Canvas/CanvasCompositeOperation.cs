using System;

namespace JavaScript.Html.DOM
{
    /// <summary>
    /// Decide how Source(A) image and Destination(B) image is composite.
    /// Check defined const members.
    /// </summary>
    public abstract class CanvasCompositeOperation
    {
        public static implicit operator CanvasCompositeOperation(string val)
        {
            return null;
        }

        /// <summary>
        /// A atop B. Display the source image wherever both images are opaque.
        /// Display the destination image wherever the destination image is opaque but the source image is transparent.
        /// Display transparency elsewhere.
        /// </summary>
        [EvalAtCompile]
        public const string SOURCE_ATOP = "source-atop";

        /// <summary>
        /// A in B. Display the source image wherever both the source image and destination image are opaque.
        /// Display transparency elsewhere.
        /// </summary>
        [EvalAtCompile]
        public const string SOURCE_IN = "source-in";

        /// <summary>
        /// A out B. Display the source image wherever the source image is opaque and the destination image is transparent.
        /// Display transparency elsewhere.
        /// </summary>
        [EvalAtCompile]
        public const string SOURCE_OUT = "source-out";

        /// <summary>
        /// A over B. Display the source image wherever the source image is opaque.
        /// Display the destination image elsewhere.
        /// </summary>
        [EvalAtCompile]
        public const string SOURCE_OVER = "source-over";

        /// <summary>
        /// B atop A. Same as source-atop but using the destination image instead of the source image and vice versa.
        /// </summary>
        [EvalAtCompile]
        public const string DEST_ATOP = "destination-atop";

        /// <summary>
        /// Same as source-in but using the destination image instead of the source image and vice versa.
        /// </summary>
        [EvalAtCompile]
        public const string DEST_IN = "destination-in";

        /// <summary>
        /// Same as source-out but using the destination image instead of the source image and vice versa.
        /// </summary>
        [EvalAtCompile]
        public const string DEST_OUT = "destination-out";

        /// <summary>
        /// B over A. Same as source-over but using the destination image instead of the source image and vice versa.
        /// </summary>
        [EvalAtCompile]
        public const string DEST_OVER = "destination-over";

        /// <summary>
        /// A plus B. Display the sum of the source image and destination image, with color values approaching 255 (100%) as a limit.
        /// </summary>
        [EvalAtCompile]
        public const string LIGHT = "lighter";

        /// <summary>
        /// A (B is ignored). Display the source image instead of the destination image.
        /// </summary>
        [EvalAtCompile]
        public const string COPY = "copy";

        /// <summary>
        /// A xor B. Exclusive OR of the source image and destination image.
        /// </summary>
        [EvalAtCompile]
        public const string XOR = "xor";
    }
}
