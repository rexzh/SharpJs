using JavaScript;

namespace enyo
{
    [NonScript]
    public class ArrangerKind : JavaScript.Object
    {
        public static implicit operator ArrangerKind(string val)
        {
            return null;
        }

        private ArrangerKind() { }
        
        [EvalAtCompile]
        public const string CardArranger = "CardArranger";
        [EvalAtCompile]
        public const string CardSlideInArranger = "CardSlideInArranger";
        [EvalAtCompile]
        public const string CarouselArranger = "CarouselArranger";
        [EvalAtCompile]
        public const string CollapsingArranger = "CollapsingArranger";
        [EvalAtCompile]
        public const string GridArranger = "GridArranger";
        [EvalAtCompile]
        public const string LeftRightArranger = "LeftRightArranger";
        [EvalAtCompile]
        public const string SpiralArranger = "SpiralArranger";
        [EvalAtCompile]
        public const string TopBottomArranger = "TopBottomArranger";
        [EvalAtCompile]
        public const string DockRightArranger = "DockRightArranger";
    }
}
