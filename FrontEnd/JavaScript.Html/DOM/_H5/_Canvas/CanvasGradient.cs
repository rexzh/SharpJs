using System;
using JavaScript.Html.DOM.CSS;

namespace JavaScript.Html.DOM
{
    public abstract class CanvasGradient : DrawStyle
    {
        /// <summary>
        /// Adds a new stop to a gradient.
        /// </summary>
        /// <param name="offset">[0, 1]</param>
        /// <param name="color"></param>
        public abstract void AddColorStop(double offset, Color color);
    }
}
