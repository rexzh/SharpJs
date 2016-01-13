using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Clip
    {
        public static implicit operator Clip(string val)
        {
            return null;
        }        

        /// <summary>
        /// The element does not clip. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";


        /// <summary>
        /// The value of the clip property is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
