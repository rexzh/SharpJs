namespace JavaScript
{
    [RenameClass("Error")]
    public class Error : System.Exception
    {
        public string name;
        public string message;

        public Error()
        {
        }

        public Error(string msg)
        {
            this.message = msg;
        }
    }

    [RenameClass("EvalError")]
    public sealed class EvalError : System.Exception
    {
        public EvalError(string msg)
            : base(msg)
        {
        }
    }

    [RenameClass("RangeError")]
    public sealed class RangeError : System.Exception
    {
        public RangeError(string msg)
            : base(msg)
        {
        }
    }

    [RenameClass("ReferenceError")]
    public sealed class ReferenceError : System.Exception
    {
        public ReferenceError(string msg)
            : base(msg)
        {
        }
    }

    [RenameClass("SyntaxError")]
    public sealed class SyntaxError : System.Exception
    {
        public SyntaxError(string msg)
            : base(msg)
        {
        }
    }

    [RenameClass("TypeError")]
    public sealed class TypeError : System.Exception
    {
        public TypeError(string msg)
            : base(msg)
        {
        }
    }

    [RenameClass("URIError")]
    public sealed class URIError : System.Exception
    {
        public URIError(string msg)
            : base(msg)
        {
        }
    }
}
