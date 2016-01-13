using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Cursor
    {
        public static implicit operator Cursor(string val)
        {
            return null;
        }

        /// <summary>
        /// Browser default cursor (often an arrow). This is default
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";


        /// <summary>
        /// Crosshair cursor
        /// </summary>
        [EvalAtCompile]
        public const string Crosshair = "crosshair";


        /// <summary>
        /// Platform-depended default cursor (often an arrow)
        /// </summary>
        [EvalAtCompile]
        public const string Default = "default";


        /// <summary>
        /// East arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string EResize = "e-resize";


        /// <summary>
        /// Arrow with question mark, indicating that help is available
        /// </summary>
        [EvalAtCompile]
        public const string Help = "help";


        /// <summary>
        /// Crossed arrows, indicating that something can be moved
        /// </summary>
        [EvalAtCompile]
        public const string Move = "move";


        /// <summary>
        /// North arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string NResize = "n-resize";


        /// <summary>
        /// North-east arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string NEResize = "ne-resize";


        /// <summary>
        /// North-west. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string NWResize = "nw-resize";


        /// <summary>
        /// Normal hand
        /// </summary>
        [EvalAtCompile]
        public const string Pointer = "pointer";


        /// <summary>
        /// South arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string SResize = "s-resize";


        /// <summary>
        /// South-east arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string SEResize = "se-resize";


        /// <summary>
        /// South-west arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string SWResize = "sw-resize";


        /// <summary>
        /// The cursor indicates text
        /// </summary>
        [EvalAtCompile]
        public const string Text = "text";

        /// <summary>
        /// West arrows. Indicates that an element is resizable
        /// </summary>
        [EvalAtCompile]
        public const string WResize = "w-resize";


        /// <summary>
        /// Hourglass or watch, indicating that the program is busy
        /// </summary>
        [EvalAtCompile]
        public const string Wait = "wait";

    }
}
