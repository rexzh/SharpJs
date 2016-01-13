using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Position
    {
        public static implicit operator Position(string val)
        {
            return null;
        }

        /// <summary>
        /// Elements renders in order, as they appear in the document flow. This is default.
        /// </summary>
        [EvalAtCompile]
        public const string Static = "static";


        /// <summary>
        /// The element is positioned relative to its first positioned (not static) ancestor element
        /// </summary>
        [EvalAtCompile]
        public const string Absolute = "absolute";


        /// <summary>
        /// The element is positioned relative to the browser window
        /// </summary>
        [EvalAtCompile]
        public const string Fixed = "fixed";


        /// <summary>
        /// The element is positioned relative to its normal position, so "left:20" adds 20 pixels to the element's LEFT position
        /// </summary>
        [EvalAtCompile]
        public const string Relative = "relative";


        /// <summary>
        /// The value of the position property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
