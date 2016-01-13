using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class TextAlign
    {
        public static implicit operator TextAlign(string val)
        {
            return null;
        }

        /// <summary>
        /// Aligns the text to the left. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Left = "left";


        /// <summary>
        /// Aligns the text to the right
        /// </summary>
        [EvalAtCompile]
        public const string Right = "right";


        /// <summary>
        /// Centers the text
        /// </summary>
        [EvalAtCompile]
        public const string Center = "center";


        /// <summary>
        /// The text is justified
        /// </summary>
        [EvalAtCompile]
        public const string Justify = "justify";


        /// <summary>
        /// The value of the textAlign property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
