using System;
using System.Collections;
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
    public static class SyntaxExtensions
    {
        public static bool IsValidMemberKind(this MemberDeclarationSyntax syntax)
        {
            switch (syntax.Kind())
            {
                case SyntaxKind.FieldDeclaration:
                case SyntaxKind.ConstructorDeclaration:
                //case SyntaxKind.PropertyDeclaration:
                case SyntaxKind.MethodDeclaration:
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Only valid for field/constructor/property/method
        /// </summary>
        /// <param name="syntax"></param>
        /// <returns></returns>
        public static bool IsStaticMember(this MemberDeclarationSyntax syntax)
        {
            SyntaxTokenList modifiers = new SyntaxTokenList();
            switch (syntax.Kind())
            {
                case SyntaxKind.FieldDeclaration:
                    var field = syntax as FieldDeclarationSyntax;
                    modifiers = field.Modifiers;
                    break;

                case SyntaxKind.PropertyDeclaration:
                    var property = syntax as PropertyDeclarationSyntax;
                    modifiers = property.Modifiers;
                    break;

                case SyntaxKind.MethodDeclaration:
                    var method = syntax as MethodDeclarationSyntax;
                    modifiers = method.Modifiers;
                    break;

                case SyntaxKind.ConstructorDeclaration:
                    var ctor = syntax as ConstructorDeclarationSyntax;
                    modifiers = ctor.Modifiers;
                    break;
            }
            foreach (var modifier in modifiers)
            {
                if (modifier.Kind() == SyntaxKind.StaticKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsStaticType(this ClassDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.StaticKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsPartial(this ClassDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.PartialKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsPartial(this MethodDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.PartialKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsExtern(this MethodDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.ExternKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsUnSafe(this MethodDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.UnsafeKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsUnSafe(this ClassDeclarationSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.UnsafeKeyword)
                    return true;
            }
            return false;
        }

        public static bool IsExtensionParameter(this ParameterSyntax syntax)
        {
            foreach (var modifier in syntax.Modifiers)
            {
                if (modifier.Kind() == SyntaxKind.ThisKeyword)
                    return true;
            }
            return false;
        }        
    }
}
