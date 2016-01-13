using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Clear
    {
        public static implicit operator Clear(string val)
        {
            return null;
        }

        /// <summary>
        /// Allows floating objects on both sides of the element. This is default
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";


        /// <summary>
        /// No floating objects allowed on the left side of the element
        /// </summary>
        [EvalAtCompile]
        public const string Left = "left";


        /// <summary>
        /// No floating objects allowed on the right side of the element
        /// </summary>
        [EvalAtCompile]
        public const string Right = "right";


        /// <summary>
        /// No floating objects allowed on either the left or right side of the element
        /// </summary>
        [EvalAtCompile]
        public const string Both = "both";
    }
}
