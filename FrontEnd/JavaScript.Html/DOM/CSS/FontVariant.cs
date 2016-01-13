using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class FontVariant
    {
        public static implicit operator FontVariant(string val)
        {
            return null;
        }

        /// <summary>
        /// The font is normal. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// The font is displayed in small capital letters
        /// </summary>
        [EvalAtCompile]
        public const string SmallCaps = "small-caps";


        /// <summary>
        /// The value of the fontVariant property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
