using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using JavaScript;

namespace SJC.Compiler
{
    public static class SemanticModelExtension
    {
        public static bool IsGlobalVariable(this SemanticModel model, MemberDeclarationSyntax member)
        {
            if (member.Kind() != SyntaxKind.FieldDeclaration)
                return false;
            var field = member as FieldDeclarationSyntax;
            var attrDeclares = field.AttributeLists;
            foreach (var attrDeclare in attrDeclares)
            {
                foreach (var attr in attrDeclare.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(GlobalVariableAttribute)))
                        return true;
                }
            }

            return false;
        }

        public static bool IsEvalCandidate(this SemanticModel model, MemberDeclarationSyntax member)
        {
            if (member.Kind() != SyntaxKind.FieldDeclaration)
                return false;
            var field = member as FieldDeclarationSyntax;
            var attrDeclares = field.AttributeLists;
            foreach (var attrDeclare in attrDeclares)
            {
                foreach (var attr in attrDeclare.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(EvalAtCompileAttribute)))
                        return true;
                }
            }

            return false;
        }
        
        public static bool IsNoCompile(this SemanticModel model, BaseFieldDeclarationSyntax syntax)
        {
            foreach (var attrListSyntax in syntax.AttributeLists)
            {
                foreach (var attr in attrListSyntax.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(NoCompileAttribute)))
                        return true;
                }
            }
            return false;
        }

        public static bool IsNoCompile(this SemanticModel model, BaseMethodDeclarationSyntax syntax)
        {
            foreach (var attrListSyntax in syntax.AttributeLists)
            {
                foreach (var attr in attrListSyntax.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(NoCompileAttribute)))
                        return true;
                }
            }
            return false;
        }

        public static string GetMemberSymbolName(this SemanticModel model, FieldDeclarationSyntax syntax)
        {
            var attrDeclares = syntax.AttributeLists;
            foreach (var attrDeclare in attrDeclares)
            {
                foreach (var attr in attrDeclare.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(RenameMemberAttribute)))
                    {
                        var val = model.GetConstantValue(attr.ArgumentList.Arguments[0].Expression);
                        return (string)val.Value;
                    }
                }
            }
            var v = syntax.Declaration.Variables[0];//Note:Field declare always declare 1 var
            return v.Identifier.ValueText.LowerCase1stChar();
        }

        public static string GetParameterSymbolName(this SemanticModel model, ParameterSyntax syntax)
        {
            var attrDeclares = syntax.AttributeLists;
            foreach (var attrDeclare in attrDeclares)
            {
                foreach (var attr in attrDeclare.Attributes)
                {
                    var type = model.GetTypeInfo(attr);
                    if (type.Type.IsSameType(nameof(JavaScript), nameof(RenameParameterAttribute)))
                    {
                        var val = model.GetConstantValue(attr.ArgumentList.Arguments[0].Expression);
                        return (string)val.Value;
                    }
                }
            }

            return syntax.Identifier.ValueText;
        }

        public static string GetDefaultValueOfType(this SemanticModel model, TypeSyntax type)
        {
            var info = model.GetTypeInfo(type);
            var cType = info.ConvertedType;

            var attrs = cType.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(ScriptDefaultValueAttribute)))
                {
                    var val = attr.NamedArguments.ElementAt(0).Value;
                    return (string)val.Value;
                }
            }

            //Note:System type list
            switch (cType.Name)
            {
                case nameof(Byte):
                case nameof(SByte):
                case nameof(Int16):
                case nameof(Int32):
                case nameof(Int64):
                case nameof(UInt16):
                case nameof(UInt32):
                case nameof(UInt64):
                case nameof(Single):
                case nameof(Double):
                case nameof(Decimal):
                    return "0";
            }

            return ("null");
        }
    }
}
