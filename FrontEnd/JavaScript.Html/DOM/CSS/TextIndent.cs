using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class TextIndent
    {
        public static implicit operator TextIndent(string val)
        {
            return null;
        }

        /// <summary>
        /// The value of the textIndent property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";	
    }
}
