using System;

namespace JavaScript.Html.DOM.CSS
{
    /// <summary>
    /// Predefined value or string with these format:
    /// <para>#RRGGBB: R/G/B is 0~FF</para>
    /// <para>rgb(r,g,b): r,g,b is 0~255</para>
    /// <para>rgba(r,g,b,a): a is 0.0(full transparent)~1.0(full opaque)</para>
    /// <para>hsl(h,s,l): h is 0~360, s/l is 0%~100%</para>
    /// <para>hsla(h,s,l,a): a is 0.0(full transparent)~1.0(full opaque)</para>
    /// </summary>
    public abstract class Color : DrawStyle
    {
        public static implicit operator Color(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string AliceBlue = "AliceBlue";

        [EvalAtCompile]
        public const string AntiqueWhite = "AntiqueWhite";

        [EvalAtCompile]
        public const string Aqua = "Aqua";

        [EvalAtCompile]
        public const string Aquamarine = "Aquamarine";

        [EvalAtCompile]
        public const string Azure = "Azure";

        [EvalAtCompile]
        public const string Beige = "Beige";

        [EvalAtCompile]
        public const string Bisque = "Bisque";

        [EvalAtCompile]
        public const string Black = "Black";

        [EvalAtCompile]
        public const string BlanchedAlmond = "BlanchedAlmond";

        [EvalAtCompile]
        public const string Blue = "Blue";

        [EvalAtCompile]
        public const string BlueViolet = "BlueViolet";

        [EvalAtCompile]
        public const string Brown = "Brown";

        [EvalAtCompile]
        public const string BurlyWood = "BurlyWood";

        [EvalAtCompile]
        public const string CadetBlue = "CadetBlue";

        [EvalAtCompile]
        public const string Chartreuse = "Chartreuse";

        [EvalAtCompile]
        public const string Chocolate = "Chocolate";

        [EvalAtCompile]
        public const string Coral = "Coral";

        [EvalAtCompile]
        public const string CornflowerBlue = "CornflowerBlue";

        [EvalAtCompile]
        public const string Cornsilk = "Cornsilk";

        [EvalAtCompile]
        public const string Crimson = "Crimson";

        [EvalAtCompile]
        public const string Cyan = "Cyan";

        [EvalAtCompile]
        public const string DarkBlue = "DarkBlue";

        [EvalAtCompile]
        public const string DarkCyan = "DarkCyan";

        [EvalAtCompile]
        public const string DarkGoldenRod = "DarkGoldenRod";

        [EvalAtCompile]
        public const string DarkGray = "DarkGray";

        [EvalAtCompile]
        public const string DarkGrey = "DarkGrey";

        [EvalAtCompile]
        public const string DarkGreen = "DarkGreen";

        [EvalAtCompile]
        public const string DarkKhaki = "DarkKhaki";

        [EvalAtCompile]
        public const string DarkMagenta = "DarkMagenta";

        [EvalAtCompile]
        public const string DarkOliveGreen = "DarkOliveGreen";

        [EvalAtCompile]
        public const string Darkorange = "Darkorange";

        [EvalAtCompile]
        public const string DarkOrchid = "DarkOrchid";

        [EvalAtCompile]
        public const string DarkRed = "DarkRed";

        [EvalAtCompile]
        public const string DarkSalmon = "DarkSalmon";

        [EvalAtCompile]
        public const string DarkSeaGreen = "DarkSeaGreen";

        [EvalAtCompile]
        public const string DarkSlateBlue = "DarkSlateBlue";

        [EvalAtCompile]
        public const string DarkSlateGray = "DarkSlateGray";

        [EvalAtCompile]
        public const string DarkSlateGrey = "DarkSlateGrey";

        [EvalAtCompile]
        public const string DarkTurquoise = "DarkTurquoise";

        [EvalAtCompile]
        public const string DarkViolet = "DarkViolet";

        [EvalAtCompile]
        public const string DeepPink = "DeepPink";

        [EvalAtCompile]
        public const string DeepSkyBlue = "DeepSkyBlue";

        [EvalAtCompile]
        public const string DimGray = "DimGray";

        [EvalAtCompile]
        public const string DimGrey = "DimGrey";

        [EvalAtCompile]
        public const string DodgerBlue = "DodgerBlue";

        [EvalAtCompile]
        public const string FireBrick = "FireBrick";

        [EvalAtCompile]
        public const string FloralWhite = "FloralWhite";

        [EvalAtCompile]
        public const string ForestGreen = "ForestGreen";

        [EvalAtCompile]
        public const string Fuchsia = "Fuchsia";

        [EvalAtCompile]
        public const string Gainsboro = "Gainsboro";

        [EvalAtCompile]
        public const string GhostWhite = "GhostWhite";

        [EvalAtCompile]
        public const string Gold = "Gold";

        [EvalAtCompile]
        public const string GoldenRod = "GoldenRod";

        [EvalAtCompile]
        public const string Gray = "Gray";

        [EvalAtCompile]
        public const string Grey = "Grey";

        [EvalAtCompile]
        public const string Green = "Green";

        [EvalAtCompile]
        public const string GreenYellow = "GreenYellow";

        [EvalAtCompile]
        public const string HoneyDew = "HoneyDew";

        [EvalAtCompile]
        public const string HotPink = "HotPink";

        [EvalAtCompile]
        public const string IndianRed = "IndianRed";

        [EvalAtCompile]
        public const string Indigo = "Indigo";

        [EvalAtCompile]
        public const string Ivory = "Ivory";

        [EvalAtCompile]
        public const string Khaki = "Khaki";

        [EvalAtCompile]
        public const string Lavender = "Lavender";

        [EvalAtCompile]
        public const string LavenderBlush = "LavenderBlush";

        [EvalAtCompile]
        public const string LawnGreen = "LawnGreen";

        [EvalAtCompile]
        public const string LemonChiffon = "LemonChiffon";

        [EvalAtCompile]
        public const string LightBlue = "LightBlue";

        [EvalAtCompile]
        public const string LightCoral = "LightCoral";

        [EvalAtCompile]
        public const string LightCyan = "LightCyan";

        [EvalAtCompile]
        public const string LightGoldenRodYellow = "LightGoldenRodYellow";

        [EvalAtCompile]
        public const string LightGray = "LightGray";

        [EvalAtCompile]
        public const string LightGrey = "LightGrey";

        [EvalAtCompile]
        public const string LightGreen = "LightGreen";

        [EvalAtCompile]
        public const string LightPink = "LightPink";

        [EvalAtCompile]
        public const string LightSalmon = "LightSalmon";

        [EvalAtCompile]
        public const string LightSeaGreen = "LightSeaGreen";

        [EvalAtCompile]
        public const string LightSkyBlue = "LightSkyBlue";

        [EvalAtCompile]
        public const string LightSlateGray = "LightSlateGray";

        [EvalAtCompile]
        public const string LightSlateGrey = "LightSlateGrey";

        [EvalAtCompile]
        public const string LightSteelBlue = "LightSteelBlue";

        [EvalAtCompile]
        public const string LightYellow = "LightYellow";

        [EvalAtCompile]
        public const string Lime = "Lime";

        [EvalAtCompile]
        public const string LimeGreen = "LimeGreen";

        [EvalAtCompile]
        public const string Linen = "Linen";

        [EvalAtCompile]
        public const string Magenta = "Magenta";

        [EvalAtCompile]
        public const string Maroon = "Maroon";

        [EvalAtCompile]
        public const string MediumAquaMarine = "MediumAquaMarine";

        [EvalAtCompile]
        public const string MediumBlue = "MediumBlue";

        [EvalAtCompile]
        public const string MediumOrchid = "MediumOrchid";

        [EvalAtCompile]
        public const string MediumPurple = "MediumPurple";

        [EvalAtCompile]
        public const string MediumSeaGreen = "MediumSeaGreen";

        [EvalAtCompile]
        public const string MediumSlateBlue = "MediumSlateBlue";

        [EvalAtCompile]
        public const string MediumSpringGreen = "MediumSpringGreen";

        [EvalAtCompile]
        public const string MediumTurquoise = "MediumTurquoise";

        [EvalAtCompile]
        public const string MediumVioletRed = "MediumVioletRed";

        [EvalAtCompile]
        public const string MidnightBlue = "MidnightBlue";

        [EvalAtCompile]
        public const string MintCream = "MintCream";

        [EvalAtCompile]
        public const string MistyRose = "MistyRose";

        [EvalAtCompile]
        public const string Moccasin = "Moccasin";

        [EvalAtCompile]
        public const string NavajoWhite = "NavajoWhite";

        [EvalAtCompile]
        public const string Navy = "Navy";

        [EvalAtCompile]
        public const string OldLace = "OldLace";

        [EvalAtCompile]
        public const string Olive = "Olive";

        [EvalAtCompile]
        public const string OliveDrab = "OliveDrab";

        [EvalAtCompile]
        public const string Orange = "Orange";

        [EvalAtCompile]
        public const string OrangeRed = "OrangeRed";

        [EvalAtCompile]
        public const string Orchid = "Orchid";

        [EvalAtCompile]
        public const string PaleGoldenRod = "PaleGoldenRod";

        [EvalAtCompile]
        public const string PaleGreen = "PaleGreen";

        [EvalAtCompile]
        public const string PaleTurquoise = "PaleTurquoise";

        [EvalAtCompile]
        public const string PaleVioletRed = "PaleVioletRed";

        [EvalAtCompile]
        public const string PapayaWhip = "PapayaWhip";

        [EvalAtCompile]
        public const string PeachPuff = "PeachPuff";

        [EvalAtCompile]
        public const string Peru = "Peru";

        [EvalAtCompile]
        public const string Pink = "Pink";

        [EvalAtCompile]
        public const string Plum = "Plum";

        [EvalAtCompile]
        public const string PowderBlue = "PowderBlue";

        [EvalAtCompile]
        public const string Purple = "Purple";

        [EvalAtCompile]
        public const string Red = "Red";

        [EvalAtCompile]
        public const string RosyBrown = "RosyBrown";

        [EvalAtCompile]
        public const string RoyalBlue = "RoyalBlue";

        [EvalAtCompile]
        public const string SaddleBrown = "SaddleBrown";

        [EvalAtCompile]
        public const string Salmon = "Salmon";

        [EvalAtCompile]
        public const string SandyBrown = "SandyBrown";

        [EvalAtCompile]
        public const string SeaGreen = "SeaGreen";

        [EvalAtCompile]
        public const string SeaShell = "SeaShell";

        [EvalAtCompile]
        public const string Sienna = "Sienna";

        [EvalAtCompile]
        public const string Silver = "Silver";

        [EvalAtCompile]
        public const string SkyBlue = "SkyBlue";

        [EvalAtCompile]
        public const string SlateBlue = "SlateBlue";

        [EvalAtCompile]
        public const string SlateGray = "SlateGray";

        [EvalAtCompile]
        public const string SlateGrey = "SlateGrey";

        [EvalAtCompile]
        public const string Snow = "Snow";

        [EvalAtCompile]
        public const string SpringGreen = "SpringGreen";

        [EvalAtCompile]
        public const string SteelBlue = "SteelBlue";

        [EvalAtCompile]
        public const string Tan = "Tan";

        [EvalAtCompile]
        public const string Teal = "Teal";

        [EvalAtCompile]
        public const string Thistle = "Thistle";

        [EvalAtCompile]
        public const string Tomato = "Tomato";

        [EvalAtCompile]
        public const string Turquoise = "Turquoise";

        [EvalAtCompile]
        public const string Violet = "Violet";

        [EvalAtCompile]
        public const string Wheat = "Wheat";

        [EvalAtCompile]
        public const string White = "White";

        [EvalAtCompile]
        public const string WhiteSmoke = "WhiteSmoke";

        [EvalAtCompile]
        public const string Yellow = "Yellow";

        [EvalAtCompile]
        public const string YellowGreen = "YellowGreen";

        /// <summary>
        /// The background color is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";	

        /// <summary>
        /// The background color is transparent (underlying content will shine through). This is default.
        /// </summary>
        [EvalAtCompile]
        public const string Transparent= "transparent";
    }
}
