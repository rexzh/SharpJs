using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class LetterSpacing
    {
        public static implicit operator LetterSpacing(string val)
        {
            return null;
        }

        /// <summary>
        /// Normal space between characters. This is default
        /// </summary>
        [EvalAtCompile]
        public const string normal = "normal";
        
        /// <summary>
        /// The value of the letterSpacing property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string inherit = "inherit";

    }
}
