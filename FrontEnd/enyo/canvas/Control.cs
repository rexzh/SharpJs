using JavaScript;
using JavaScript.Html.DOM;

namespace enyo.canvas
{
    [NoCompile]
    public class Bounds
    {
        public Number l;
        public Number t;
        public Number w;
        public Number h;

        public Number start_x;
        public Number start_y;
        public Number finish_x;
        public Number finish_y;
        public Number width;

        [RenameMember("Style")]
        public CanvasStyle Style;

        public CanvasLineCap cap;
    }

    public abstract class Control : UiComponent
    {
        public Bounds Bounds { get; set; }

        public EnyoEventHandler<Control, EnyoEventArgs> onRender;

        public abstract void RenderSelf(Context2D ctx);
    }
}
