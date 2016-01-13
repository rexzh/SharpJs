using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class StyleImage
    {
        public static implicit operator StyleImage(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string None = "none";

        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
