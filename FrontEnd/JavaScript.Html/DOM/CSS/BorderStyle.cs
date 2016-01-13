using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class BorderStyle
    {
        public static implicit operator BorderStyle(string val)
        {
            return null;
        }

        /// <summary>
        /// Defines no border. This is default
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";

        /// <summary>
        /// The same as "none", except in border conflict resolution for table elements
        /// </summary>
        [EvalAtCompile]
        public const string Hidden = "hidden";

        /// <summary>
        /// Defines a dotted border
        /// </summary>
        [EvalAtCompile]
        public const string Dotted = "dotted";

        /// <summary>
        /// Defines a dashed border
        /// </summary>
        [EvalAtCompile]
        public const string Dashed = "dashed";

        /// <summary>
        /// Defines a solid border
        /// </summary>
        [EvalAtCompile]
        public const string Solid = "solid";

        /// <summary>
        /// Defines two borders. The width of the two borders are the same as the border-width value
        /// </summary>
        [EvalAtCompile]
        public const string Double = "double";

        /// <summary>
        /// Defines a 3D grooved border. The effect depends on the border-color value
        /// </summary>
        [EvalAtCompile]
        public const string Groove = "groove";

        /// <summary>
        /// Defines a 3D ridged border. The effect depends on the border-color value
        /// </summary>
        [EvalAtCompile]
        public const string Ridge = "ridge";

        /// <summary>
        /// Defines a 3D inset border. The effect depends on the border-color value
        /// </summary>
        [EvalAtCompile]
        public const string Inset = "inset";

        /// <summary>
        /// Defines a 3D outset border. The effect depends on the border-color value
        /// </summary>
        [EvalAtCompile]
        public const string Outset = "outset";

        /// <summary>
        /// The style of the border is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
