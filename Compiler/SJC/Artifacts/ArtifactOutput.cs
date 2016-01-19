using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SJC.Artifacts
{
    public class ArtifactOutput
    {
        private IJavaScriptOutput _jsOutput;
        public IJavaScriptOutput JsOutput
        {
            get { return _jsOutput; }
            set { _jsOutput = value; }
        }

        private bool _generateSourceMap;
        public bool GenerateSourceMap
        {
            get { return _generateSourceMap; }
            set { _generateSourceMap = value; }
        }

        private ISourceMapOutput _sourceMapOutput;
        public ISourceMapOutput SourceMapOutput
        {
            get { return _sourceMapOutput; }
            set { _sourceMapOutput = value; }
        }

        private void DebugWrite(SyntaxNodeOrToken node, Position pos, string str)
        {
            if (node.Kind() == SyntaxKind.IdentifierName || node.Kind() == SyntaxKind.IdentifierToken || node.Kind() == SyntaxKind.ObjectCreationExpression)
                System.Diagnostics.Debug.WriteLine($"{node} ---> [{node.Kind()} | {pos}] ---> {str}");
        }

        public void IncreaseIndent()
        {
            _jsOutput.IncreaseIndent();
        }

        public void DecreaseIndent()
        {
            _jsOutput.DecreaseIndent();
        }

        public void TrivialWriteLine()
        {
            _jsOutput.WriteLine();
        }

        public void TrivialWrite(char ch)
        {
            _jsOutput.Write(ch);
        }

        public void TrivialWrite(string str)
        {
            _jsOutput.Write(str);
        }

        public void TrivialWriteLine(char ch)
        {
            _jsOutput.WriteLine(ch);
        }

        public void TrivialWriteLine(string str)
        {
            _jsOutput.WriteLine(str);
        }

        public void Write(SyntaxNodeOrToken syntax, String str)
        {
            var pos = _jsOutput.Write(str);
            this.DebugWrite(syntax, pos, str);
        }

        public void Write(SyntaxNodeOrToken syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.Write(str);
            this.DebugWrite(syntax, pos, str);
        }

        public void WriteLine(SyntaxNodeOrToken syntax, String str)
        {
            var pos = _jsOutput.WriteLine(str);
            this.DebugWrite(syntax, pos, str);
        }

        public void WriteLine(SyntaxNodeOrToken syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.WriteLine(str);
            this.DebugWrite(syntax, pos, str);
        }
    }
}
