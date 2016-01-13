using JavaScript;

namespace enyo
{
    [NonScript]
    public class HandleAs
    {
        public static implicit operator HandleAs(string val) { return null; }

        [EvalAtCompile]
        public const string Json = "json";
        [EvalAtCompile]
        public const string Text = "text";
        [EvalAtCompile]
        public const string Xml = "xml";
    }
}
