using System;
using JavaScript.Html.DOM;

namespace enyo.canvas
{
    public class Shape : Control
    {
        public string Color { get; set; }
        public string OutlineColor { get; set; }

        public virtual void Draw(Context2D ctx)
        {
        }

        public override void RenderSelf(Context2D ctx)
        {
        }
    }
}
