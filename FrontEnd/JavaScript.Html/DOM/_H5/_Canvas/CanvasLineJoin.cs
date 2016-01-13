using System;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasLineJoin
    {
        public static implicit operator CanvasLineJoin(string str)
        {
            return null;
        }

        [EvalAtCompile]
        public const string Bevel = "bevel";

        [EvalAtCompile]
        public const string Round = "round";

        [EvalAtCompile]
        public const string Miter = "miter";
    }
}
