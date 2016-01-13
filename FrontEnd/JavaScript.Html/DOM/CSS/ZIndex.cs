using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class ZIndex
    {
        public static implicit operator ZIndex(string val)
        {
            return null;
        }

        public static implicit operator ZIndex(int val)
        {
            return null;
        }

        /// <summary>
        /// The browser determines the stack order of the element (based on its order in the document). This is default
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";	

        /// <summary>
        /// The value of the zIndex property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
