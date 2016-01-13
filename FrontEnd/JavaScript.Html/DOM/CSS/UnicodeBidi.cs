using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class UnicodeBidi
    {
        public static implicit operator UnicodeBidi(string val)
        {
            return null;
        }

        /// <summary>
        /// Does not use an additional level of embedding. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// Creates an additional level of embedding
        /// </summary>
        [EvalAtCompile]
        public const string Embed = "embed";


        /// <summary>
        /// Creates an additional level of embedding. Reordering depends on the direction property
        /// </summary>
        [EvalAtCompile]
        public const string BidiOverride = "bidi-override";


        /// <summary>
        /// The value of the unicodeBidi property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";

    }
}
