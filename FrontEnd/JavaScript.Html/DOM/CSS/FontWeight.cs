using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class FontWeight
    {
        public static implicit operator FontWeight(string val)
        {
            return null;
        }

        /// <summary>
        /// Font is normal. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Normal = "normal";


        /// <summary>
        /// Font is lighter
        /// </summary>
        [EvalAtCompile]
        public const string Lighter = "lighter";


        /// <summary>
        /// Font is bold
        /// </summary>
        [EvalAtCompile]
        public const string Bold = "bold";


        /// <summary>
        /// Font is bolder
        /// </summary>
        [EvalAtCompile]
        public const string Bolder = "bolder";


        /// <summary>
        /// 100
        /// </summary>
        [EvalAtCompile]
        public const string W100 = "100";


        /// <summary>
        /// 200
        /// </summary>
        [EvalAtCompile]
        public const string W200 = "200";


        /// <summary>
        /// 300
        /// </summary>
        [EvalAtCompile]
        public const string W300 = "300";


        /// <summary>
        /// same as normal
        /// </summary>
        [EvalAtCompile]
        public const string W400 = "400";


        /// <summary>
        /// 500
        /// </summary>
        [EvalAtCompile]
        public const string W500 = "500";


        /// <summary>
        /// 600
        /// </summary>
        [EvalAtCompile]
        public const string W600 = "600";


        /// <summary>
        /// 700 is the same as bold
        /// </summary>
        [EvalAtCompile]
        public const string W700 = "700";


        /// <summary>
        /// 800
        /// </summary>
        [EvalAtCompile]
        public const string W800 = "800";


        /// <summary>
        /// 900
        /// </summary>
        [EvalAtCompile]
        public const string W900 = "900";


        /// <summary>
        /// The value of the fontWeight property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
