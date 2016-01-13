using System;
using JavaScript;

namespace enyo
{
    [RenameClass("enyo.easing")]
    public static class Easing
    {
        public static Func<int, int> CubicIn;
        public static Func<int, int> CubicOut;

        public static Func<int, int> ExpoOut;
        public static Func<int, int> QuadInOut;

        public static Func<int, int> Linear;
    }
}
