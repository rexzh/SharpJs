using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class TextTransform
    {
        public static implicit operator TextTransform(string val)
        {
            return null;
        }

        /// <summary>
        /// No characters are converted. This is default
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";


        /// <summary>
        /// The first character of each word is converted to uppercase
        /// </summary>
        [EvalAtCompile]
        public const string Capitalize = "capitalize";


        /// <summary>
        /// All characters are converted to uppercase
        /// </summary>
        [EvalAtCompile]
        public const string Uppercase = "uppercase";


        /// <summary>
        /// All characters are converted to lowercase
        /// </summary>
        [EvalAtCompile]
        public const string Lowercase = "lowercase";


        /// <summary>
        /// The value of the textTransform property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
