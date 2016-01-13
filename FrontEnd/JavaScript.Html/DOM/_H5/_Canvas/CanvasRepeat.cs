using System;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasRepeat
    {
        public static implicit operator CanvasRepeat(string val)
        {
            return null;
        }

        /// <summary>
        /// The background image is repeated both vertically and horizontally. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Repeat = "repeat";

        /// <summary>
        /// The background image is only repeated horizontally
        /// </summary>
        [EvalAtCompile]
        public const string RepeatX = "repeat-x";

        /// <summary>
        /// The background image is only repeated vertically
        /// </summary>
        [EvalAtCompile]
        public const string RepeatY = "repeat-y";

        /// <summary>
        /// The background-image is not repeated
        /// </summary>
        [EvalAtCompile]
        public const string NoRepeat = "no-repeat";
    }
}
