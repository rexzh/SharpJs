using JavaScript;

namespace UnitTestSample_1
{
    [NoCompile]
    public static class Def
    {
        [EvalAtCompile]
        public const string XX = "x" + "x";
    }

    class ConstEval
    {
        public string V = Def.XX;
    }
}
