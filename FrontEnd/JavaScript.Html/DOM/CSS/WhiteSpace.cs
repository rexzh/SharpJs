using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class WhiteSpace
    {
        public static implicit operator WhiteSpace(string val)
        {
            return null;
        }

        /// <summary>
        /// Collapses sequences of whitespace, and breaks lines automatically. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// Collapses sequences of whitespace, but does not allow line breaks
        /// </summary>
        [EvalAtCompile]
        public const string Nowrap = "nowrap";


        /// <summary>
        /// Line breaks and other whitespace are preserved
        /// </summary>
        [EvalAtCompile]
        public const string Pre = "pre";


        /// <summary>
        /// The value of the whiteSpace property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
