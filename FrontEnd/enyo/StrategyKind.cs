using JavaScript;

namespace enyo
{
    [NonScript]
    public class StrategyKind
    {
        private StrategyKind() { }

        public static implicit operator StrategyKind(string val)
        {
            return null;
        }
        
        [EvalAtCompile]
        public const string ScrollStrategy = "ScrollStrategy";

        [EvalAtCompile]
        public const string TouchScrollStrategy = "TouchScrollStrategy";

        [EvalAtCompile]
        public const string TranslateScrollStrategy = "TranslateScrollStrategy";

        [EvalAtCompile]
        public const string TransitionScrollStrategy = "TransitionScrollStrategy";
    }
}
