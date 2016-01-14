using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using JavaScript;

namespace SJC.Compiler
{
    public static class SymbolExtension
    {
        public static bool IsSameType(this ITypeSymbol type, string ns, string name)
        {
            return type.ContainingNamespace.Name == ns && type.Name == name;
        }

        public static bool IsGlobalVariable(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(GlobalVariableAttribute)))
                    return true;
            }
            return false;
        }

        public static bool IsNativeMethod(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(JsNativeAttribute)))
                    return true;
            }
            return false;
        }

        public static bool IsScriptSymbol(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(NonScriptAttribute)))
                    return false;
            }
            return true;
        }

        public static bool IsOperator(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(OperatorAttribute)))
                    return true;
            }
            return false;
        }

        public static OperatorDefination GetOperatorDefination(this ISymbol symbol)
        {
            OperatorDefination def = new OperatorDefination();
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(OperatorAttribute)))
                {
                    def.Token = (string)attr.ConstructorArguments[0].Value;
                    if (attr.ConstructorArguments.Length > 1)
                    {
                        switch ((int)attr.ConstructorArguments[1].Value)
                        {
                            case 1:
                                def.Type = OperatorType.Unary;
                                break;

                            case 2:
                                def.Type = OperatorType.Binary;
                                break;

                            default:
                                def.Type = OperatorType.Unsupported;
                                break;
                        }
                    }
                    else//Note: Default is Binary
                    {
                        def.Type = OperatorType.Binary;
                    }

                    if (attr.ConstructorArguments.Length > 2)
                    {
                        def.Prefix = (bool)attr.ConstructorArguments[2].Value;
                    }
                }
            }
            return def;
        }

        public static bool IsEvalCandidate(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(EvalAtCompileAttribute)))
                    return true;
            }
            return false;
        }

        public static bool HasEvalSuggestValue(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(EvalAtCompileAttribute)))
                {
                    return attr.NamedArguments.Count() > 0;
                }
            }
            return false;
        }

        public static object ReadEvalSuggestValue(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(EvalAtCompileAttribute)))
                {
                    return attr.NamedArguments.ElementAt(0).Value;
                }
            }
            return null;
        }

        public static bool IsNoCompile(this ISymbol symbol)
        {
            foreach (var attr in symbol.GetAttributes())
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(NoCompileAttribute)))
                    return true;
            }
            return false;
        }

        public static string GetMemberSymbolName(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(RenameMemberAttribute)))
                {
                    var val = attr.ConstructorArguments.ElementAt(0).Value;
                    return (string)val;
                }
            }

            return symbol.Name.LowerCase1stChar();
        }

        public static string GetTypeSymbolName(this ISymbol symbol)
        {
            var name = string.Empty;
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(RenameClassAttribute)))
                {
                    var cs = attr.ConstructorArguments[0].Value;

                    var fqn = cs.ToString();
                    name = fqn.TrimStart('.').TrimEnd('.');

                    return name;
                }
            }

            return symbol.ContainingSymbol + "." + symbol.Name;
        }

        public static string GetParameterSymbolName(this ISymbol symbol)
        {
            var attrs = symbol.GetAttributes();
            foreach (var attr in attrs)
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(RenameParameterAttribute)))
                {
                    var val = attr.ConstructorArguments.ElementAt(0).Value;
                    return (string)val;
                }
            }
            return symbol.Name;
        }

        public static bool GetEnumValue(this ISymbol symbol, out string val)
        {
            foreach (var attr in symbol.GetAttributes())
            {
                if (attr.AttributeClass.IsSameType(nameof(JavaScript), nameof(EnumValueAttribute)))
                {
                    if (attr.ConstructorArguments.ElementAt(0).Value == null)
                        val = null;
                    else
                        val = string.Format("\"{0}\"", attr.ConstructorArguments.ElementAt(0).Value);
                    return true;
                }
            }

            val = null;
            return false;
        }
    }
}
