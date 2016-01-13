using JavaScript;

namespace enyo
{
    [NonScript]
    public class ComponentKind : JavaScript.Object
    {
        public static implicit operator ComponentKind(string str)
        {
            return null;
        }

        protected ComponentKind() { }
        
        [EvalAtCompile]
        public const string Component = "enyo.Component";

        [EvalAtCompile]
        public const string ScrollThumb = "enyo.ScrollThumb";

        [EvalAtCompile]
        public const string Repeater = "enyo.Repeater";

        [EvalAtCompile]
        public const string Panels = "enyo.Panels";

        [EvalAtCompile]
        public const string DragAvatar = "enyo.DragAvatar";

        [EvalAtCompile]
        public const string Input = "enyo.Input";

        [EvalAtCompile]
        public const string Checkbox = "enyo.Checkbox";

        [EvalAtCompile]
        public const string WebService = "enyo.WebService";

        [EvalAtCompile]
        public const string Option = "enyo.Option";

        [EvalAtCompile]
        public const string Animator = "enyo.Animator";

        [EvalAtCompile]
        public const string GroupItem = "enyo.GroupItem";

        [EvalAtCompile]
        public const string ToolDecorator = "enyo.ToolDecorator";

        [EvalAtCompile]
        public const string ScrollMath = "enyo.ScrollMath";

        [EvalAtCompile]
        public const string Select = "enyo.Select";

        [EvalAtCompile]
        public const string Scroller = "enyo.Scroller";

        [EvalAtCompile]
        public const string Node = "enyo.Node";

        [EvalAtCompile]
        public const string TextArea = "enyo.TextArea";

        [EvalAtCompile]
        public const string FlyweightRepeater = "enyo.FlyweightRepeater";

        [EvalAtCompile]
        public const string Slideable = "enyo.Slideable";

        [EvalAtCompile]
        public const string Signals = "enyo.Signals";

        [EvalAtCompile]
        public const string Group = "enyo.Group";

        [EvalAtCompile]
        public const string Popup = "enyo.Popup";

        [EvalAtCompile]
        public const string List = "enyo.List";

        [EvalAtCompile]
        public const string Image = "enyo.Image";

        [EvalAtCompile]
        public const string FittableColumns = "enyo.FittableColumns";

        [EvalAtCompile]
        public const string Selection = "enyo.Selection";

        [EvalAtCompile]
        public const string RichText = "enyo.RichText";

        [EvalAtCompile]
        public const string OwnerProxy = "enyo.OwnerProxy";

        [EvalAtCompile]
        public const string FittableRows = "enyo.FittableRows";

        [EvalAtCompile]
        public const string Button = "enyo.Button";

        [EvalAtCompile]
        public const string PulldownList = "enyo.PulldownList";
        
        [EvalAtCompile]
        public const string Canvas = "enyo.Canvas";

        [EvalAtCompile]
        public const string Canvas_Shape = "enyo.canvas.Shape";

        [EvalAtCompile]
        public const string Canvas_Circle = "enyo.canvas.Circle";

        [EvalAtCompile]
        public const string Canvas_Line = "enyo.canvas.Line";

        [EvalAtCompile]
        public const string Canvas_Image = "enyo.canvas.Image";

        [EvalAtCompile]
        public const string Canvas_Rectangle = "enyo.canvas.Rectangle";

        [EvalAtCompile]
        public const string Canvas_Text = "enyo.canvas.Text";
    }
}
