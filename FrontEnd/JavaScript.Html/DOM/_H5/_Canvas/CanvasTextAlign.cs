using System;

namespace JavaScript.Html.DOM
{
    /// <summary>    
    /// Check const defined in class.
    /// </summary>
    public abstract class CanvasTextAlign
    {
        public static implicit operator CanvasTextAlign(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string Start = "start";

        [EvalAtCompile]
        public const string End = "end";

        [EvalAtCompile]
        public const string Left = "left";

        [EvalAtCompile]
        public const string Right = "right";

        [EvalAtCompile]
        public const string Center = "center";
    }
}
