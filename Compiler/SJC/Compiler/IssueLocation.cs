using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace SJC.Compiler
{
    public class IssueLocation
    {
        public static IssueLocation NA = new IssueLocation();

        private IssueLocation()
        {
        }

        public IssueLocation(SyntaxTree tree, SyntaxNode node)
        {
            this._fileName = Path.GetFullPath(tree.FilePath);
            InitPosition(tree, node.Span);
        }

        public IssueLocation(SyntaxTree tree, SyntaxToken token)
        {
            this._fileName = Path.GetFullPath(tree.FilePath);
            InitPosition(tree, token.Span);
        }

        private void InitPosition(SyntaxTree tree, TextSpan span)
        {
            var x = tree.GetLineSpan(span);
            this._line = x.StartLinePosition.Line + 1;
            this._column = x.StartLinePosition.Character + 1;

            this._endLine = x.EndLinePosition.Line + 1;
            this._endColumn = x.EndLinePosition.Character + 1;
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
        }

        private int _line;
        public int Line
        {
            get { return _line; }
        }

        private int _column;
        public int Column
        {
            get { return _column; }
        }

        private int _endLine;
        public int EndLine
        {
            get { return _endLine; }
        }

        private int _endColumn;
        public int EndColumn
        {
            get { return _endColumn; }
        }

        public override string ToString()
        {
            return string.Format("file {0}, ({1},{2},{3},{4}):", this.FileName, this.Line, this.Column, this.EndLine, this.EndColumn);
        }
    }
}
