using System;

namespace JavaScript.Html.DOM
{
    public abstract class ContextType
    {
        public static implicit operator ContextType(string val)
        {
            return null;
        }

        [EvalAtCompile]
        public const string D2 = "2d";
    }
}
