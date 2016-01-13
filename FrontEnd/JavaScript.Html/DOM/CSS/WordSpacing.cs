using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class WordSpacing
    {
        public static implicit operator WordSpacing(string val)
        {
            return null;
        }

        /// <summary>
        /// Defines normal spacing between words. This is default
        /// </summary>
        [EvalAtCompile]
        public const string normal = "normal";      


        /// <summary>
        /// The value of the wordSpacing property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string inherit = "inherit";

    }
}
