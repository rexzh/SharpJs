using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class BackgroundRepeat
    {
        public static implicit operator BackgroundRepeat(string val)
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

        /// <summary>
        /// The setting of the background-repeat property is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
