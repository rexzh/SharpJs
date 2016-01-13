using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Overflow
    {
        public static implicit operator Overflow(string val)
        {
            return null;
        }

        /// <summary>
        /// Content is NOT clipped and may be shown outside the element box. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Visible = "visible";


        /// <summary>
        /// Content outside the element box is not shown
        /// </summary>
        [EvalAtCompile]
        public const string Hidden = "hidden";


        /// <summary>
        /// Scroll bars are added, and content is clipped when necessary
        /// </summary>
        [EvalAtCompile]
        public const string Scroll = "scroll";


        /// <summary>
        /// Content is clipped and scroll bars are added when necessary
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";


        /// <summary>
        /// The value of the overflow property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
