using JavaScript;

namespace enyo
{
    [NonScript]
    public class Direction
    {
        public static implicit operator Direction(string val)
        {
            return null;
        }

        private Direction() { }

        [EvalAtCompile]
        public const string H = "h";
        [EvalAtCompile]
        public const string V = "v";
    }
}
