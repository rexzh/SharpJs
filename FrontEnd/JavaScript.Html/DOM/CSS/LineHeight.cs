using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class LineHeight
    {
        public static implicit operator LineHeight(string val)
        {
            return null;
        }

        public static implicit operator LineHeight(uint val)
        {
            return null;
        }


        /// <summary>
        /// Normal line height is used. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// The value of the lineHeight property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
