using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class FontStyle
    {
        public static implicit operator FontStyle(string val)
        {
            return null;
        }

        /// <summary>
        /// Font is normal. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// Font is in italic
        /// </summary>
        [EvalAtCompile]
        public const string Italic = "italic";


        /// <summary>
        /// Font is in oblique
        /// </summary>
        [EvalAtCompile]
        public const string Oblique = "oblique";


        /// <summary>
        /// The value of the fontStyle property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
