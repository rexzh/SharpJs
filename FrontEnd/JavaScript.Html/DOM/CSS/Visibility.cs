using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Visibility
    {
        public static implicit operator Visibility(string val)
        {
            return null;
        }

        /// <summary>
        /// The element is visible. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Visible = "visible";


        /// <summary>
        /// The element is not visible, but still affects layout
        /// </summary>
        [EvalAtCompile]
        public const string Hidden = "hidden";


        /// <summary>
        /// When used on a table row or cell, the element is not visible (same as "hidden")
        /// </summary>
        [EvalAtCompile]
        public const string Collapse = "collapse";


        /// <summary>
        /// The value of the visibility property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
