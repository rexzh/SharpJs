using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class VerticalAlign
    {
        public static implicit operator VerticalAlign(string val)
        {
            return null;
        }

        /// <summary>
        /// Align the baseline of the element with the baseline of the parent element. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Baseline = "baseline";


        /// <summary>
        /// Aligns the element as it was subscript
        /// </summary>
        [EvalAtCompile]
        public const string Sub = "sub";


        /// <summary>
        /// Aligns the element as it was superscript
        /// </summary>
        [EvalAtCompile]
        public const string Super = "super";


        /// <summary>
        /// The top of the element is aligned with the top of the tallest element on the line
        /// </summary>
        [EvalAtCompile]
        public const string Top = "top";


        /// <summary>
        /// The top of the element is aligned with the top of the parent element's font
        /// </summary>
        [EvalAtCompile]
        public const string TextTop = "text-top";


        /// <summary>
        /// The element is placed in the middle of the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Middle = "middle";


        /// <summary>
        /// The bottom of the element is aligned with the lowest element on the line
        /// </summary>
        [EvalAtCompile]
        public const string Bottom = "bottom";


        /// <summary>
        /// The bottom of the element is aligned with the bottom of the parent element's font
        /// </summary>
        [EvalAtCompile]
        public const string TextBottom = "text-bottom";


        /// <summary>
        /// Specifies that the value of the verticalAlign property should be inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
