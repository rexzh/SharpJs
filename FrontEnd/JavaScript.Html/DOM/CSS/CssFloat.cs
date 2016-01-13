using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class CssFloat
    {
        public static implicit operator CssFloat(string val)
        {
            return null;
        }

        /// <summary>
        /// The object/element will float to the left in the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Left = "left";


        /// <summary>
        /// The object/element will float to the right in the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Right = "right";


        /// <summary>
        /// The object/element is not floated. This is default
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";


        /// <summary>
        /// The value of the cssFloat property is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
