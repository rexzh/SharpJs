using System;

using Microsoft.CodeAnalysis;

namespace SJC.Artifacts
{
    public interface ISourceMapOutput : IDisposable
    {   
        int Version { get; set; }
        string File { get; }
        string SourceRoot { get; set; }
        string[] Sources { get; }
        string[] Names { get; }
        string Mappings { get; }

        void AddSource(string source);
        void AddName(string name);
        void AddMapping(SyntaxNodeOrToken node, Position pos);
    }
}
