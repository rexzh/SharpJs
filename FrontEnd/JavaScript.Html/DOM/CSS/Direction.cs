using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Direction
    {
        public static implicit operator Direction(string val)
        {
            return null;
        }

        /// <summary>
        /// Text flows from left to right. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Ltr = "ltr";


        /// <summary>
        /// Text flows from right to left
        /// </summary>
        [EvalAtCompile]
        public const string Rtl = "rtl";


        /// <summary>
        /// Text direction is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
