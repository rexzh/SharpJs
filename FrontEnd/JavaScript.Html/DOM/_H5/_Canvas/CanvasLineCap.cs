using System;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasLineCap
    {
        public static implicit operator CanvasLineCap(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string Butt = "butt";

        [EvalAtCompile]
        public const string Round = "round";

        [EvalAtCompile]
        public const string Square = "square";
    }
}
