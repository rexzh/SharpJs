using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class BackgroundPosition
    {
        public static implicit operator BackgroundPosition(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string TopLeft = "top left";

        [EvalAtCompile]
        public const string TopCenter = "top center";

        [EvalAtCompile]
        public const string TopRight = "top right";

        [EvalAtCompile]
        public const string CenterLeft = "center left";

        [EvalAtCompile]
        public const string CenterCenter = "center center";

        [EvalAtCompile]
        public const string CenterRight = "center right";

        [EvalAtCompile]
        public const string BottomLeft = "bottom left";

        [EvalAtCompile]
        public const string BottomCenter = "bottom center";

        [EvalAtCompile]
        public const string BottomRight = "bottom right";

        /// <summary>
        /// The setting of the background-position property is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";        
    }
}
