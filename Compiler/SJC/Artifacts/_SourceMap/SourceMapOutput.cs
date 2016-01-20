using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using RexToy;

using SJC.Base64VLQ;

namespace SJC.Artifacts
{
    abstract class SourceMapOutput : ISourceMapOutput
    {
        public abstract void Dispose();

        protected abstract void Write(string str);
        protected abstract void WriteLine(string str);

        public int Version { get; set; } = 3;

        public string File { get; set; }

        public string SourceRoot { get; set; }

        private List<string> _sources;
        public string[] Sources
        {
            get
            {
                return _sources.ToArray();
            }
        }

        private List<string> _names;
        public string[] Names
        {
            get
            {
                return _names.ToArray();
            }
        }

        private StringBuilder _mapping;
        public string Mappings
        {
            get
            {
                return _mapping.ToString();
            }
        }

        private string _indent = new string(' ', 4);

        protected SourceMapOutput()
        {
            _sources = new List<string>();
            _mapping = new StringBuilder();
            _names = new List<string>();
        }

        protected void Flush()
        {
            WriteLine("{");
            WriteLine($"{_indent}version: {Version},");
            WriteLine($"{_indent}file: \"{File}\",");
            WriteLine($"{_indent}sourceRoot: \"{SourceRoot}\",");
            Write($"{_indent}sources: [");
            int count = 0;
            foreach (var s in Sources)
            {
                Write($"\"{s}\"");
                count++;
                if (count < Sources.Length)
                    Write(",");
            }
            WriteLine($"],");
            Write($"{_indent}names: [");
            count = 0;
            foreach (var n in Names)
            {
                Write($"\"n\"");
                count++;
                if (count < Names.Length)
                    Write(",");
            }
            WriteLine($"],");
            WriteLine($"{_indent}mappings: \"{Mappings}\"");
            WriteLine("}");
        }

        private int _srcIdx;
        public void AddSource(string source)
        {
            source = source.RemoveBegin('\\').Replace('\\', '/');

            _sources.Add(source);
            _srcIdx = _sources.Count - 1;
        }

        public void AddName(string name)
        {
            _names.Add(name);
        }

        private int _line = 0;
        public void AddMapping(SyntaxNodeOrToken node, Position pos)
        {
            var srcPos = node.GetLocation().GetLineSpan().StartLinePosition;
            if (_line == pos.Line)
            {
                if (_mapping.Length > 0 && _mapping[_mapping.Length - 1] != ';')
                    _mapping.Append(',');
            }
            else
            {
                while (_line < pos.Line)
                {
                    _mapping.Append(';');
                    _line++;
                }
            }
            
            _mapping.Append(Base64VLQEncoding.Encode(pos.Column));
            _mapping.Append(Base64VLQEncoding.Encode(_srcIdx));
            _mapping.Append(Base64VLQEncoding.Encode(srcPos.Line));
            _mapping.Append(Base64VLQEncoding.Encode(srcPos.Character));
        }
    }
}
