
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SJC.Compiler
{
    public class TypeWalker : SyntaxWalker
    {
        private SemanticModel _model;
        private SyntaxTreeRelationship _relation;
        public TypeWalker(SemanticModel model, SyntaxTreeRelationship relation)
        {
            _model = model;
            _relation = relation;
        }

        public override void Visit(SyntaxNode node)
        {
            switch(node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    VisitClassDeclaration((ClassDeclarationSyntax)node);
                    break;

                case SyntaxKind.InterfaceDeclaration:
                    VisitInterfaceDeclaration((InterfaceDeclarationSyntax)node);
                    break;

                case SyntaxKind.EnumDeclaration:
                    VisitEnumDeclaration((EnumDeclarationSyntax)node);
                    break;
            }
            base.Visit(node);
        }

        private void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var type = _model.GetDeclaredSymbol(node);
            _relation.AddProvide(type);
            if (node.BaseList != null)
            {
                foreach (var b in node.BaseList.Types)
                {
                    var bType = _model.GetTypeInfo(b.Type);                    
                    _relation.AddDependency(bType.Type);
                }
            }
        }

        public void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var type = _model.GetDeclaredSymbol(node);
            _relation.AddProvide(type);
        }

        public void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            var type = _model.GetDeclaredSymbol(node);
            _relation.AddProvide(type);
        }
    }
}
