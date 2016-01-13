using System;
using JavaScript.Html.DOM.CSS;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasStyle
    {
        public static implicit operator CanvasStyle(Color color)
        {
            return null;
        }

        public static implicit operator CanvasStyle(CanvasGradient gradient)
        {
            return null;
        }

        public static implicit operator CanvasStyle(CanvasPattern pattern)
        {
            return null;
        }

        public static implicit operator CanvasStyle(string val)
        {
            return null;
        }
    }
}
