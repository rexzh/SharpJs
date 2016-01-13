using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

namespace SJC.Compiler
{
    public class SyntaxTreeRelationship
    {
        private SyntaxTree _tree;
        public SyntaxTree Tree
        {
            get { return _tree; }
        }

        private List<INamedTypeSymbol> _provides;
        public IEnumerable<INamedTypeSymbol> Provides
        {
            get { return _provides; }
        }

        private List<ITypeSymbol> _dependencies;
        public IEnumerable<ITypeSymbol> Dependencies
        {
            get { return _dependencies; }
        }

        public SyntaxTreeRelationship(SyntaxTree tree)
        {
            _tree = tree;
            _provides = new List<INamedTypeSymbol>();
            _dependencies = new List<ITypeSymbol>();
        }

        public void AddProvide(INamedTypeSymbol provide)
        {
            if (provide == null)
                throw new ArgumentNullException("provider");
            _provides.Add(provide);
        }

        public void AddDependency(ITypeSymbol dependency)
        {
            if (dependency == null)
                throw new ArgumentNullException("dependency");
            _dependencies.Add(dependency);
        }

        public bool IsDependOn(SyntaxTreeRelationship that)
        {
            foreach (var d in this._dependencies)
            {
                foreach (var p in that._provides)
                {
                    if (d.ContainingNamespace == p.ContainingNamespace && d.Name == p.Name)
                        return true;
                }
            }
            return false;
        }
    }
}
