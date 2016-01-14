using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using RexToy;

namespace SJC.Compiler
{
    partial class Rewriter
    {
        private string MakeInterfacesList(ClassDeclarationSyntax syntax)
        {
            var interfaces = _semanticModel.GetDeclaredSymbol(syntax).Interfaces;

            StringBuilder str = new StringBuilder();
            foreach (var info in interfaces)
            {
                if (!info.IsScriptSymbol())
                {
                    this.AppendCompileIssue(syntax, IssueType.Error, IssueId.UseNonScript, info);
                }
                str.AppendFormat("{0}, ", info.GetTypeSymbolName());
            }
            if (interfaces.Count() > 0)
                str.RemoveEnd(", ");

            return str.ToString();
        }

        private string MakeParametersList(ParameterListSyntax syntax)
        {
            var args = syntax.Parameters;
            StringBuilder str = new StringBuilder();
            if (args.Count > 0)
            {
                var fstArg = args[0];
                if (fstArg.IsExtensionParameter())
                    this.AppendCompileIssue(syntax, IssueType.Error, IssueId.ExtensionMethodNotSupport);

                foreach (var arg in args)
                {
                    var info = _semanticModel.GetDeclaredSymbol(arg);
                    if (!info.Type.IsScriptSymbol())
                    {
                        this.AppendCompileIssue(syntax, IssueType.Error, IssueId.UseNonScript, info.Type);
                    }

                    if (arg.Default != null)
                    {
                        this.AppendCompileIssue(syntax, IssueType.Error, IssueId.DefaultParamNotSupport);
                    }

                    str.Append(_semanticModel.GetParameterSymbolName(arg)).Append(", ");
                }
                str.RemoveEnd(", ");
            }
            return str.ToString();
        }

        private void MakeLocalVariableList(VariableDeclarationSyntax syntax)
        {
            int count = 0;
            foreach (var v in syntax.Variables)
            {
                if (count == 0)
                {
                    _output.Write(v.Identifier.ValueText);
                }
                else
                {
                    _output.Write(", ");
                    _output.Write(v.Identifier.ValueText);
                }

                if (v.Initializer != null)
                {
                    _output.Write(" = ");
                    this.Visit(v.Initializer);
                }
                count++;
            }
        }

        private void MakeArgumentsList(SeparatedSyntaxList<ArgumentSyntax> syntaxList)
        {
            int count = 0;
            foreach (var arg in syntaxList)
            {
                if (arg.NameColon != null)
                {
                    this.AppendCompileIssue(arg, IssueType.Error, IssueId.NamedArgumentNotSupport);
                }

                this.VisitExpression(arg.Expression);
                count++;
                if (count != syntaxList.Count)
                    _output.Write(", ");
            }
        }


        private void MakeExpressionList(SeparatedSyntaxList<ExpressionSyntax> list)
        {
            int count = 0;
            foreach (var expr in list)
            {
                if (count != 0)
                    _output.Write(", ");

                this.VisitExpression(expr);
                count++;
            }
        }

        private bool IsNameOfOperator(InvocationExpressionSyntax syntax)
        {
            if (syntax.Expression.Kind() == SyntaxKind.IdentifierName)
            {
                var id = syntax.Expression as IdentifierNameSyntax;
                if (id?.Identifier.Text == "nameof")
                    return true;
            }
            return false;
        }

        private bool IsPropertyAccess(ExpressionSyntax syntax)
        {
            if (syntax.Kind() != SyntaxKind.SimpleMemberAccessExpression)
                return false;
            var maes = (MemberAccessExpressionSyntax)syntax;
            var symbol = _semanticModel.GetSymbolInfo(maes.Name);
            return symbol.Symbol.Kind == SymbolKind.Property;
        }

        private bool IsPartOfDynamic(ExpressionSyntax syntax)
        {
            var maes = syntax as MemberAccessExpressionSyntax;
            if (maes != null)
            {
                var info = _semanticModel.GetTypeInfo(maes.Expression);

                //Extend:Should not occur, doubt it's Roslyn's bug while compile object create initialize syntax.
                if (info.Type == null)
                    return false;

                if (info.Type.Kind == SymbolKind.DynamicType)
                    return true;

                if (info.Type.Kind == SymbolKind.ErrorType)
                {
                    if (maes.Expression.Kind() == SyntaxKind.SimpleMemberAccessExpression)
                    {
                        var expr = maes.Expression as MemberAccessExpressionSyntax;
                        return IsPartOfDynamic(expr.Expression);
                    }

                    if (maes.Expression.Kind() == SyntaxKind.InvocationExpression)
                    {
                        var expr = maes.Expression as InvocationExpressionSyntax;
                        return IsPartOfDynamic(expr.Expression);
                    }
                }

                return false;
            }
            else
            {
                var info = _semanticModel.GetTypeInfo(syntax);
                if (info.Type != null && info.Type.Kind == SymbolKind.DynamicType)
                    return true;
            }

            return false;
        }

        private void VisitExpression(ExpressionSyntax syntax)
        {
            var constant = _semanticModel.GetConstantValue(syntax);
            var info = _semanticModel.GetSymbolInfo(syntax);

            if (info.Symbol != null && info.Symbol.IsEvalCandidate())
            {
                if (constant.HasValue)
                {
                    if (info.Symbol.HasEvalSuggestValue())
                    {
                        _output.Write(info.Symbol.ReadEvalSuggestValue().ToString());
                    }
                    else
                    {
                        if (constant.Value == null)
                            _output.Write("null");
                        else
                        {
                            if (constant.Value is string)
                            {
                                _output.Write("\"" + constant.Value.ToString() + "\"");
                            }
                            else
                            {
                                _output.Write(constant.Value.ToString());
                            }
                        }
                    }
                }
                else
                {
                    this.AppendCompileIssue(syntax, IssueType.Error, IssueId.NotConstant, syntax);
                }
            }
            else
            {
                Visit(syntax);
            }
        }

        private void AppendCompensateSemicolon(StatementSyntax syntax)
        {
            if (!(syntax.Kind() == SyntaxKind.Block))
            {
                if (syntax.Kind() == SyntaxKind.ExpressionStatement || syntax.Kind() == SyntaxKind.ThrowStatement || syntax.Kind() == SyntaxKind.ReturnStatement)
                    _output.WriteLine(";");
            }
        }

        private void OutputNativeMethod(BlockSyntax node)
        {
            var txt = node.GetText().ToString().Trim();//Note: Leading/Trailing white space
            txt = txt.UnBracketing(StringPair.CurlyBracket).Trim();
            txt = txt.UnBracketing(StringPair.Create("/*", "*/"));
            string[] lines = txt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            _output.WriteLine("//**Js Native code start");
            _output.WriteLine(txt);
            _output.WriteLine("//**Js Native code end");
        }

        private void GenerateMethodCode(SimpleNameSyntax node, ISymbol symbol)
        {
            if (node.Parent.Kind() != SyntaxKind.SimpleMemberAccessExpression)
            {
                if (symbol.IsStatic)
                {
                    _output.Write("{0}.", symbol.ContainingType.GetTypeSymbolName());
                }
                else
                {
                    _output.Write("this.");
                }
            }
            _output.Write(symbol.GetMemberSymbolName());
        }

        private bool IsGlobalHolder(ExpressionSyntax syntax)
        {
            var info = _semanticModel.GetSymbolInfo(syntax);
            if (info.Symbol != null && info.Symbol.Kind == SymbolKind.NamedType)
            {
                var name = info.Symbol.GetTypeSymbolName();
                return string.IsNullOrEmpty(name);
            }

            return false;
        }

        private bool IsArrayOrStringLengthAccess(MemberAccessExpressionSyntax syntax)
        {
            var info = _semanticModel.GetSymbolInfo(syntax);
            var type = _semanticModel.GetTypeInfo(syntax.Expression);
            return info.Symbol != null && info.Symbol.Name == "Length" && (type.Type.SpecialType == SpecialType.System_String || type.Type.Kind == SymbolKind.ArrayType);
        }

        private ISymbol GetSymbolOrOverloadSymbol(CSharpSyntaxNode node)
        {
            var info = _semanticModel.GetSymbolInfo(node);

            if (info.Symbol != null)
                return info.Symbol;

            //Note: the C# compiler already compile this project, so if there is only 1 candidate for the overload resolve fail reason, we can think this is valid symbol
            if (info.CandidateSymbols.Count() == 1 && info.CandidateReason == CandidateReason.OverloadResolutionFailure)
            {
                this.AppendCompileIssue(node, IssueType.Warning, IssueId.OverloadResolveOnlyOne);
                return info.CandidateSymbols[0];
            }

            return null;
        }
    }
}
