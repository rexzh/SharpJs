using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class FontSize
    {
        public static implicit operator FontSize(string val)
        {
            return null;
        }

        /// <summary>
        /// xxs
        /// </summary>
        [EvalAtCompile]
        public const string XXSmall = "xx-small";


        /// <summary>
        /// xs
        /// </summary>
        [EvalAtCompile]
        public const string XSmall = "x-small";


        /// <summary>
        /// s
        /// </summary>
        [EvalAtCompile]
        public const string Small = "small";


        /// <summary>
        /// m
        /// </summary>
        [EvalAtCompile]
        public const string Medium = "medium";


        /// <summary>
        /// l
        /// </summary>
        [EvalAtCompile]
        public const string Large = "large";


        /// <summary>
        /// xl
        /// </summary>
        [EvalAtCompile]
        public const string XLarge = "x-large";


        /// <summary>
        /// xxl
        /// </summary>
        [EvalAtCompile]
        public const string XXLarge = "xx-large";


        /// <summary>
        /// Decreases the font-size by one relative unit
        /// </summary>
        [EvalAtCompile]
        public const string Smaller = "smaller";


        /// <summary>
        /// Increases the font-size by one relative unit
        /// </summary>
        [EvalAtCompile]
        public const string Larger = "larger";


        /// <summary>
        /// The value of the fontSize property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
