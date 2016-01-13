using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Distance
    {
        public static implicit operator Distance(string val)
        {
            return null;
        }

        /// <summary>
        /// The browser sets the bottom margin
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";

        /// <summary>
        /// The bottom margin is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

        /// <summary>
        /// No limit on the element.
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";
    }
}
