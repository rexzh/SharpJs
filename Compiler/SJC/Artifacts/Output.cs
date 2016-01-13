using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Artifacts
{
    public abstract class Output : IOutput
    {
        private const char SPACE = ' ';

        private int _indent = 0;
        private String _indentString;
        private bool _newLine = false;

        protected Output(IndentType indentType = IndentType.Space4)
        {
            switch (indentType)
            {
                case IndentType.Space2:
                    _indentString = new string(SPACE, 2);
                    break;

                case IndentType.Space8:
                    _indentString = new string(SPACE, 8);
                    break;

                case IndentType.Tab:
                    _indentString = "\t";
                    break;

                default://Note: Default 4 space.
                    _indentString = new string(SPACE, 4);
                    break;
            }
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

        public void Write(char ch)
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(ch);
            if (System.Environment.NewLine.Length == 1 && System.Environment.NewLine[0] == ch)
                this._newLine = true;
            else
                this._newLine = false;
        }

        public void Write(string str)
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(str);
            if (str.EndsWith(System.Environment.NewLine))
                this._newLine = true;
            else
                this._newLine = false;
        }

        public void Write(string fmt, params object[] args)
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(string.Format(fmt, args));
            if (fmt.EndsWith(System.Environment.NewLine))
                this._newLine = true;
            else
                this._newLine = false;
        }

        public void WriteLine()
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
        }

        public void WriteLine(string str)
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(str);
            this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
        }

        public void WriteLine(string fmt, params object[] args)
        {
            if (_newLine)
                this.WriteIndent();
            this.WriteContent(string.Format(fmt, args));
            this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
        }

        public void WriteEmptyLine()
        {
            this.WriteContent(System.Environment.NewLine);
            this._newLine = true;
        }

        public abstract void WriteContent(string str);
        public abstract void WriteContent(char ch);

        public abstract void Flush();
        public abstract void Dispose();
    }
}
