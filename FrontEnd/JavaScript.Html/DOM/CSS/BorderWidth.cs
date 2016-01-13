using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class BorderWidth
    {
        public static implicit operator BorderWidth(string val)
        {
            return null;
        }

        /// <summary>
        /// Defines a thin border
        /// </summary>
        [EvalAtCompile]
        public const string Thin = "thin";

        /// <summary>
        /// Defines a medium border. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Medium = "medium";

        /// <summary>
        /// Defines a thick border
        /// </summary>
        [EvalAtCompile]
        public const string Thick = "thick";

        /// <summary>
        /// The width of the left border is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
