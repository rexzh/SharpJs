using JavaScript;

namespace enyo
{
    [NonScript]
    public static class LayoutKind
    {
        [EvalAtCompile]
        public const string FittableLayout = "FittableLayout";
        [EvalAtCompile]
        public const string FittableColumnsLayout = "FittableColumnsLayout";
        [EvalAtCompile]
        public const string FittableRowsLayout = "FittableColumnsLayout";
    }
}
