using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class TextDecoration
    {
        public static implicit operator TextDecoration(string val)
        {
            return null;
        }

        /// <summary>
        /// Defines a normal text. This is default
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";


        /// <summary>
        /// Defines a line under the text
        /// </summary>
        [EvalAtCompile]
        public const string Underline = "underline";


        /// <summary>
        /// Defines a line over the text
        /// </summary>
        [EvalAtCompile]
        public const string Overline = "overline";


        /// <summary>
        /// Defines a line through the text
        /// </summary>
        [EvalAtCompile]
        public const string LineThrough = "line-through";


        /// <summary>
        /// The value of the textDecoration property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
