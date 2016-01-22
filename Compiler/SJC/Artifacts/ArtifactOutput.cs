using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SJC.Artifacts
{
    public sealed class ArtifactOutput : IDisposable
    {
        private bool _generateSourceMap;
        public bool GenerateSourceMap
        {
            get { return _generateSourceMap; }
            set { _generateSourceMap = value; }
        }

        private ISourceMapOutput _sourceMapOutput;
        private IJavaScriptOutput _jsOutput;

        public bool IsWriting
        {
            get { return _jsOutput != null; }
        }

        public void UseJavaScriptOutput(IJavaScriptOutput output)
        {
            this._jsOutput = output;
        }

        public void UseSourceMapOutput(ISourceMapOutput output)
        {
            this._sourceMapOutput = output;
        }

        public void CloseCurrentOutput()
        {
            this._jsOutput.Dispose();
            this._sourceMapOutput.Dispose();
        }

        public void AddSourceMap(string srcFile)
        {
            this._sourceMapOutput.AddSource(srcFile);
        }

        private void WriteSourceMap(SyntaxNodeOrToken node, Position pos, string str)
        {
            if (node.Kind() == SyntaxKind.IdentifierName || node.Kind() == SyntaxKind.IdentifierToken || node.Kind() == SyntaxKind.ObjectCreationExpression)
            {
                System.Diagnostics.Debug.WriteLine($"{node} ---> [{node.Kind()} | {pos}] ---> {str}");
                _sourceMapOutput.AddMapping(node, pos);
            }
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
            this.WriteSourceMap(syntax, pos, str);
        }

        public void Write(SyntaxNodeOrToken syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.Write(str);
            this.WriteSourceMap(syntax, pos, str);
        }

        public void WriteLine(SyntaxNodeOrToken syntax, String str)
        {
            var pos = _jsOutput.WriteLine(str);
            this.WriteSourceMap(syntax, pos, str);
        }

        public void WriteLine(SyntaxNodeOrToken syntax, String fmt, params object[] args)
        {
            var str = string.Format(fmt, args);
            var pos = _jsOutput.WriteLine(str);
            this.WriteSourceMap(syntax, pos, str);
        }

        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                _jsOutput.Dispose();
                _sourceMapOutput.Dispose();
            }
            _disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
