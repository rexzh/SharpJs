using System;

namespace JavaScript.Html.DOM
{
    /// <summary>
    /// Check const defined in class.
    /// </summary>
    public abstract class CanvasTextBaseline
    {
        public static implicit operator CanvasTextBaseline(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string Alphabetic = "alphabetic";

        [EvalAtCompile]
        public const string Bottom = "bottom";

        [EvalAtCompile]
        public const string Hanging = "hanging";

        [EvalAtCompile]
        public const string Ideographic = "ideographic";

        [EvalAtCompile]
        public const string Middle = "middle";

        [EvalAtCompile]
        public const string Top = "top";
    }
}
