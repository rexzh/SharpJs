using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SJC.Artifacts
{
    //TODO:
    public class ArtifactOutput
    {
        private IJavaScriptOutput _jsOutput;
        public IJavaScriptOutput JsOutput
        {
            get { return _jsOutput; }
            set { _jsOutput = value; }
        }

        public void IncreaseIndent()
        {
            _jsOutput.IncreaseIndent();
        }

        public void DecreaseIndent()
        {
            _jsOutput.DecreaseIndent();
        }

        public void WriteLine()
        {
            _jsOutput.WriteLine();
        }

        public void Write(char ch)
        {
            _jsOutput.Write(ch);
        }

        public void WriteLine(char ch)
        {
            _jsOutput.WriteLine(ch);
        }

        private bool DebugOutput(SyntaxToken token)
        {
            return !token.IsKeyword();
        }

        public void Write(SyntaxNode syntax, String str)
        {
            var pos = _jsOutput.Write(str);
            if (syntax != null)
                System.Diagnostics.Debug.WriteLine($"{syntax} | {pos}: {str}");
        }

        public void Write(SyntaxNode syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.Write(str);
            if (syntax != null)
                System.Diagnostics.Debug.WriteLine($"{syntax} | {pos}: {str}");
        }

        public void WriteLine(SyntaxNode syntax, String str)
        {
            var pos = _jsOutput.WriteLine(str);
            if (syntax != null)
                System.Diagnostics.Debug.WriteLine($"{syntax} | {pos}: {str}");
        }

        public void WriteLine(SyntaxNode syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.WriteLine(str);
            if (syntax != null)
                System.Diagnostics.Debug.WriteLine($"{syntax} | {pos}: {str}");
        }

        public void Write(SyntaxToken token, String str)
        {
            var pos = _jsOutput.Write(str);
            if (token != null && DebugOutput(token))
                System.Diagnostics.Debug.WriteLine($"{token} | {pos}: {str}");
        }

        public void Write(SyntaxToken token, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.Write(str);
            if (token != null && DebugOutput(token))
                System.Diagnostics.Debug.WriteLine($"{token} | {pos}: {str}");
        }

        public void WriteLine(SyntaxToken token, String str)
        {
            var pos = _jsOutput.WriteLine(str);
            if (token != null && DebugOutput(token))
                System.Diagnostics.Debug.WriteLine($"{token} | {pos}: {str}");
        }

        public void WriteLine(SyntaxToken token, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.WriteLine(str);
            if (token != null && DebugOutput(token))
                System.Diagnostics.Debug.WriteLine($"{token} | {pos}: {str}");
        }
    }
}
