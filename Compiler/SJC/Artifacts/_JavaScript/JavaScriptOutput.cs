using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RexToy;

namespace SJC.Artifacts
{
    public abstract class JavaScriptOutput : IJavaScriptOutput
    {
        private const char SPACE = ' ';

        private int _indent = 0;
        private String _indentString;
        private bool _newLine = false;

        protected int IndentLength
        {
            get { return _indentString.Length * _indent; }
        }

        private int _line = 0;
        private int _column = 0;

        protected JavaScriptOutput(IndentType indentType = IndentType.Space4)
        {
            switch (indentType)
            {
                case IndentType.Space2:
                    _indentString = new string(SPACE, 2);
                    break;

                case IndentType.Space8:
                    _indentString = new string(SPACE, 8);
                    break;

                default://Note: Default 4 space.
                    _indentString = new string(SPACE, 4);
                    break;
            }
        }

        //Note: adjust string if it contains NewLine, and return length of last segment
        private int Correction(string str)
        {
            if (str.EndsWith(System.Environment.NewLine))
                str = str.RemoveEnd(System.Environment.NewLine);

            int result = str.Length;
            int idx = str.LastIndexOf(System.Environment.NewLine);
            if (idx >= 0)
            {
                string lastLine = str.Substring(idx + System.Environment.NewLine.Length);
                result = lastLine.Length;
            }

            while (idx >= 0)
            {
                _line++;
                str = str.Substring(0, idx);
                idx = str.LastIndexOf(System.Environment.NewLine);
            }

            return result;
        }

        public int IndentLevel
        {
            get
            {
                return _indent;
            }
        }

        public void DecreaseIndent()
        {
            _indent--;
            if (_indent < 0)
                throw new InvalidOperationException("Indent level < 0.");
        }

        public void IncreaseIndent()
        {
            _indent++;
        }

        public void ResetIndent()
        {
            _indent = 0;
        }

        private void WriteIndent()
        {
            for (int i = 0; i < _indent; i++)
                this.WriteContent(this._indentString);
        }

        public Position Write(char ch)
        {
            if (_newLine)
            {
                this.WriteIndent();
                _column += IndentLength;
            }
            Position start = new Position(_line, _column);
            this.WriteContent(ch);
            if (System.Environment.NewLine.Length == 1 && System.Environment.NewLine[0] == ch)
            {
                this._newLine = true;
                _line++;
                _column = 0;
            }
            else
            {
                this._newLine = false;
                _column += 1;
            }
            return start;
        }

        public Position Write(string str)
        {
            if (_newLine)
            {
                this.WriteIndent();
                _column += IndentLength;
            }
            Position start = new Position(_line, _column);
            this.WriteContent(str);
            int colCorrection = Correction(str);
            if (str.EndsWith(System.Environment.NewLine))
            {
                this._newLine = true;
                _line++;
                _column = 0;
            }
            else
            {
                this._newLine = false;
                _column += colCorrection;
            }
            return start;
        }

        public Position WriteLine()
        {
            Position start = new Position(_line, _column);
            this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
            _line++;
            _column = 0;
            return start;
        }

        public Position WriteLine(char ch)
        {
            Position start = this.Write(ch);
            this.WriteLine();
            return start;
        }

        public Position WriteLine(string str)
        {
            if (_newLine)
            {
                this.WriteIndent();
                _column += IndentLength;
            }
            Position start = new Position(_line, _column);
            this.WriteContent(str);
            this.Correction(str);
            if (!str.EndsWith(System.Environment.NewLine))
                this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
            _line++;
            _column = 0;
            return start;
        }

        public abstract void WriteContent(string str);
        public abstract void WriteContent(char ch);

        public abstract void Flush();
        public abstract void Dispose();
    }
}
