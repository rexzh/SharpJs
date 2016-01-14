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
        public override SyntaxNode VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.StringInterpolation);
            _output.Write('"');
            _output.Write(node.Contents.ToFullString());
            _output.Write('"');
            return node;
        }

        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (IsNameOfOperator(node))
            {
                _output.Write('"');
                this.Visit(node.ArgumentList);
                _output.Write('"');
                return node;
            }

            if (IsPartOfDynamic(node.Expression))
            {
                _output.Write(node.Expression.GetText().ToString().Trim());//Note: Dynamic, output without change
                this.AppendCompileIssue(node, IssueType.Warning, IssueId.DynamicType);
            }
            else
            {
                var symbol = this.GetSymbolOrOverloadSymbol(node.Expression);
                if (symbol.IsOperator())
                {
                    OperatorDefination def = symbol.GetOperatorDefination();
                    switch (def.Type)
                    {
                        case OperatorType.Unary:
                            if (def.Prefix)
                            {
                                _output.Write(def.Token);
                                this.MakeArgumentsList(node.ArgumentList.Arguments);
                            }
                            else
                            {
                                this.MakeArgumentsList(node.ArgumentList.Arguments);
                                _output.Write(def.Token);
                            }
                            break;

                        case OperatorType.Binary:
                            this.Visit(node.ArgumentList.Arguments[0]);
                            _output.Write(def.Token);
                            this.Visit(node.ArgumentList.Arguments[1]);
                            break;

                        case OperatorType.Unsupported:
                            this.AppendCompileIssue(node, IssueType.Error, IssueId.OnlyUnaryOrBinary, symbol.Name);
                            break;
                    }
                    return node;
                }
                else
                    this.VisitExpression(node.Expression);
            }
            _output.Write('(');
            this.MakeArgumentsList(node.ArgumentList.Arguments);
            _output.Write(')');

            return node;
        }

        public override SyntaxNode VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            _output.Write('[');
            int count = 0;
            foreach (var expr in node.Expressions)
            {
                Visit(expr);
                count++;
                if (count < node.Expressions.Count)
                    _output.Write(", ");
            }
            _output.Write(']');
            return node;
        }

        public override SyntaxNode VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            switch (node.Kind())
            {
                case SyntaxKind.FalseLiteralExpression:
                    _output.Write("false");
                    break;

                case SyntaxKind.TrueLiteralExpression:
                    _output.Write("true");
                    break;

                case SyntaxKind.NullLiteralExpression:
                    _output.Write("null");
                    break;

                case SyntaxKind.NumericLiteralExpression:
                    string num = node.GetText().ToString().Trim();//Note:Keep everything, e.g. prefix 0, in C#, it has no meaning, but it means octet in js
                    if (!char.IsNumber(num[num.Length - 1]))//Note:Remove postfix, since C# has l,m etc as postfix.
                    {
                        num = num.Substring(0, num.Length - 1);
                    }
                    _output.Write(num);
                    break;

                case SyntaxKind.StringLiteralExpression:
                    string str = node.Token.ValueText.Bracketing(StringPair.DoubleQuote);
                    if (str[0] == '@')
                    {
                        str = str.Substring(1);

                        this.AppendCompileIssue(node, IssueType.Warning, IssueId.StringPrefixIgnore);
                    }
                    _output.Write(str);
                    break;

                case SyntaxKind.CharacterLiteralExpression:
                    _output.Write(node.Token.ValueText.Bracketing(StringPair.SingleQuote));
                    break;

                default:
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.UnknownExpressionType, node.Kind());
                    break;
            }

            return node;
        }

        public override SyntaxNode VisitElementAccessExpression(ElementAccessExpressionSyntax node)
        {
            this.VisitExpression(node.Expression);
            _output.Write('[');
            if (node.ArgumentList.Arguments.Count > 1)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.MultiDimensionArrayAccessNotSupport);
            }
            this.MakeArgumentsList(node.ArgumentList.Arguments);
            _output.Write(']');
            return node;
        }

        public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            switch (node.OperatorToken.Kind())
            {
                case SyntaxKind.AsKeyword:
                    this.VisitExpression(node.Left);
                    //Note:as operator is used for case, jscript don't care it, ignore.
                    break;

                case SyntaxKind.QuestionQuestionToken:
                    Visit(node.Left);
                    _output.Write(" || ");
                    Visit(node.Right);
                    break;

                case SyntaxKind.IsKeyword:
                    Visit(node.Left);
                    _output.Write(" instanceof ");
                    Visit(node.Right);
                    break;

                default:
                    this.VisitExpression(node.Left);
                    _output.Write(' ' + node.OperatorToken.ValueText + ' ');
                    this.VisitExpression(node.Right);
                    break;
            }

            return node;
        }


        public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
        {
            if (node.Left.Kind() == SyntaxKind.IdentifierName)
            {
                var id = node.Left as IdentifierNameSyntax;
                _output.Write(id.Identifier.ValueText);
            }
            else
            {
                this.Visit(node.Left);
                _output.Write(node.DotToken.ValueText);
                _output.Write(node.Right.Identifier.ValueText);
            }
            return node;
        }

        public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            _output.Write('(');
            this.VisitExpression(node.Expression);
            _output.Write(')');
            return node;
        }

        public override SyntaxNode VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            if (IsPropertyAccess(node.Operand))
                this.AppendCompileIssue(node, IssueType.Error, IssueId.PropertyAccessIssue);

            _output.Write(node.OperatorToken.ValueText);
            this.Visit(node.Operand);

            return node;
        }

        public override SyntaxNode VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            if (IsPropertyAccess(node.Operand))
                this.AppendCompileIssue(node, IssueType.Error, IssueId.PropertyAccessIssue);

            this.Visit(node.Operand);
            _output.Write(node.OperatorToken.ValueText);

            return node;
        }

        public override SyntaxNode VisitThisExpression(ThisExpressionSyntax node)
        {
            _output.Write("this");
            return node;
        }

        public override SyntaxNode VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Warning, IssueId.ConditionalAccess);
            this.Visit(node.Expression);
            switch (node.WhenNotNull.Kind())
            {
                case SyntaxKind.ElementBindingExpression:
                    var eb = node.WhenNotNull as ElementBindingExpressionSyntax;
                    _output.Write('[');
                    this.Visit(eb.ArgumentList);
                    _output.Write(']');
                    break;

                case SyntaxKind.MemberBindingExpression:
                    var mb = node.WhenNotNull as MemberBindingExpressionSyntax;
                    _output.Write('.');
                    this.Visit(mb.Name);
                    break;
            }

            return node;
        }

        private bool _isSetter;
        public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            if (IsArrayOrStringLengthAccess(node))
            {
                this.VisitExpression(node.Expression);
                _output.Write(".length");
                return node;
            }

            if (node.Expression.Kind() == SyntaxKind.ThisExpression)
            {
                var nInfo = _semanticModel.GetSymbolInfo(node.Name);

                if (nInfo.Symbol != null && nInfo.Symbol.IsGlobalVariable())
                {
                    this.AppendCompileIssue(node, IssueType.Warning, IssueId.GlobalVarWithThis);
                }
            }

            if (IsPartOfDynamic(node))
            {
                _output.Write(node.GetText().ToString());//Note: Dyanmic, output without change
                this.AppendCompileIssue(node, IssueType.Warning, IssueId.DynamicType);
                return node;
            }
            else
            {
                var info = _semanticModel.GetSymbolInfo(node.Expression);

                if (info.Symbol != null && info.Symbol.Kind == SymbolKind.NamedType)
                {
                    _output.Write(info.Symbol.GetTypeSymbolName());
                    if (!IsGlobalHolder(node.Expression))
                    {
                        _output.Write(".");
                    }
                    this.Visit(node.Name);
                }
                else
                {
                    this.VisitExpression(node.Expression);
                    _output.Write(".");

                    _isSetter = (node.Parent.Kind().IsAssignment() && _isAssignLeft);
                    this.Visit(node.Name);
                }

                return node;
            }
        }

        public override SyntaxNode VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            if (node.Initializer != null)
            {
                if (node.ArgumentList != null && node.ArgumentList.Arguments.Count > 0)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.CtorParamWithInitializer);
                }

                int addParameterNumber = _semanticModel.CheckAddMethodParameterNumber(node);
                switch (addParameterNumber)
                {
                    case 1:
                        _output.Write('[');
                        break;

                    default:
                        _output.Write('{');
                        break;
                }

                var count = 0;
                foreach (var init_exp in node.Initializer.Expressions)
                {
                    switch (init_exp.Kind())
                    {
                        case SyntaxKind.SimpleAssignmentExpression:
                            var aexp = init_exp as AssignmentExpressionSyntax;
                            switch (aexp.Left.Kind())
                            {
                                case SyntaxKind.IdentifierName:
                                    var identifier = aexp.Left as IdentifierNameSyntax;
                                    string name = identifier.Identifier.ValueText.LowerCase1stChar();
                                    _output.Write("\"{0}\": ", name);
                                    break;

                                case SyntaxKind.ImplicitElementAccess:
                                    var implicitIdx = aexp.Left as ImplicitElementAccessSyntax;

                                    this.Visit(implicitIdx.ArgumentList);
                                    _output.Write(": ");
                                    break;
                            }

                            this.VisitExpression(aexp.Right);

                            count++;
                            if (count < node.Initializer.Expressions.Count)
                            {
                                _output.Write(", ");
                            }
                            break;

                        case SyntaxKind.ComplexElementInitializerExpression:
                            var iexp = init_exp as InitializerExpressionSyntax;
                            int i_count = 0;
                            foreach (var item in iexp.Expressions)
                            {
                                this.Visit(item);
                                if (i_count < iexp.Expressions.Count - 1)
                                    _output.Write(": ");
                                else
                                    if (count < node.Initializer.Expressions.Count - 1)
                                    _output.Write(", ");
                                i_count++;
                            }
                            count++;
                            break;

                        default:
                            this.VisitExpression(init_exp);
                            count++;
                            if (count < node.Initializer.Expressions.Count)
                            {
                                _output.Write(", ");
                            }
                            break;
                    }
                }

                switch (addParameterNumber)
                {
                    case 1:
                        _output.Write(']');
                        break;

                    default:
                        _output.Write('}');
                        break;
                }
            }
            else
            {
                var info = _semanticModel.GetTypeInfo(node);

                if (info.Type.SpecialType == SpecialType.System_Object)
                {
                    _output.Write("{}");
                }
                else if (info.Type.TypeKind == TypeKind.Delegate)
                {
                    this.MakeArgumentsList(node.ArgumentList.Arguments);
                }
                else
                {
                    var name = info.Type.GetTypeSymbolName();
                    _output.Write("new " + name + "(");

                    if (node.ArgumentList != null)
                        this.MakeArgumentsList(node.ArgumentList.Arguments);

                    _output.Write(')');
                }
            }

            return node;
        }

        public override SyntaxNode VisitBaseExpression(BaseExpressionSyntax node)
        {
            if (string.IsNullOrEmpty(_template.BaseKeyword))
                this.AppendCompileIssue(node, IssueType.Error, IssueId.BaseCallNotSupport);
            else
                _output.Write(_template.BaseKeyword);
            return node;
        }

        public override SyntaxNode VisitCastExpression(CastExpressionSyntax node)
        {
            //Note:Js don't care type, throw the type info away.
            VisitExpression(node.Expression);
            return node;
        }

        public override SyntaxNode VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
        {
            if (node.Rank > 1)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.MultiDimensionArrayAccessNotSupport);
            }
            return node;
        }

        public override SyntaxNode VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            _output.Write('[');

            foreach (var rs in node.Type.RankSpecifiers)
                this.Visit(rs);

            int count = 0;
            if (node.Initializer != null)
            {
                foreach (var expr in node.Initializer.Expressions)
                {
                    this.VisitExpression(expr);
                    count++;
                    if (count != node.Initializer.Expressions.Count)
                        _output.Write(", ");
                }
            }

            _output.Write(']');

            return node;
        }

        public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            _output.Write("function ({0}) ", this.MakeParametersList(node.ParameterList));
            _output.WriteLine("{");

            _output.IncreaseIndent();
            this.Visit(node.Block);
            _output.DecreaseIndent();

            _output.Write("}");
            return node;
        }

        public override SyntaxNode VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            _output.Write('{');
            int count = 0;
            foreach (var member in node.Initializers)
            {
                string left = member.NameEquals.Name.Identifier.ValueText;

                _output.Write("\"" + NamingConvention.LowerCase1stChar(left) + "\"");

                _output.Write(": ");

                this.VisitExpression(member.Expression);
                count++;
                if (count != node.Initializers.Count)
                    _output.Write(", ");
            }
            _output.Write('}');
            return node;
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node)
        {
            ISymbol symbol = this.GetSymbolOrOverloadSymbol(node);
            if (symbol == null)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.SemanticBind);

            }
            else
            {
                switch (symbol.Kind)
                {
                    case SymbolKind.Method:
                        GenerateMethodCode(node, symbol);
                        break;

                    default:
                        this.AppendCompileIssue(node, IssueType.Error, IssueId.UnknownGenericName);
                        break;
                }
            }
            return node;
        }

        public override SyntaxNode VisitFromClause(FromClauseSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.LinqNotSupport);
            return node;
        }

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            var symbol = this.GetSymbolOrOverloadSymbol(node);
            if (symbol == null)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.SemanticBind);
                _output.Write(node.Identifier.ValueText.LowerCase1stChar());
                return node;
            }

            if (!symbol.IsScriptSymbol())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UseNonScript, symbol.Name);
            }

            switch (symbol.Kind)
            {
                case SymbolKind.Field:
                    if (node.Parent.Kind() != SyntaxKind.SimpleMemberAccessExpression)
                    {
                        if (symbol.IsStatic)
                        {
                            _output.Write("{0}.", symbol.ContainingType.GetTypeSymbolName());
                        }
                        else
                        {
                            if (!symbol.IsGlobalVariable())
                                _output.Write("this.");
                        }
                    }

                    if (node.Parent.Kind() == SyntaxKind.SimpleMemberAccessExpression)
                    {
                        MemberAccessExpressionSyntax pmaes = node.Parent as MemberAccessExpressionSyntax;
                        if (pmaes.Expression == node)
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
                    }

                    _output.Write(symbol.GetMemberSymbolName());
                    break;

                case SymbolKind.Local:
                case SymbolKind.Parameter:
                    _output.Write(symbol.GetParameterSymbolName());
                    break;

                case SymbolKind.NamedType:
                    var typeSymbol = symbol as ITypeSymbol;
                    var name = typeSymbol.GetTypeSymbolName();
                    _output.Write(name);
                    break;

                case SymbolKind.Method:
                    GenerateMethodCode(node, symbol);
                    break;

                case SymbolKind.Property:
                    if (_isSetter && node.Parent.Kind() == SyntaxKind.SimpleMemberAccessExpression)
                    {
                        _output.Write("set{0}", symbol.Name);
                    }
                    else
                    {
                        _output.Write("get{0}()", symbol.Name);
                    }
                    break;

                case SymbolKind.Namespace:
                    _output.Write(symbol.Name);
                    break;

                default:
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.UnknownSymbol, symbol.Kind);
                    break;
            }
            return node;
        }

        public override SyntaxNode VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            this.VisitExpression(node.Condition);
            _output.Write(" ? ");
            this.VisitExpression(node.WhenTrue);
            _output.Write(" : ");
            this.VisitExpression(node.WhenFalse);
            return node;
        }

        public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            var info = _semanticModel.GetTypeInfo(node);

            _output.Write("function ({0}) ", node.Parameter.Identifier.ValueText);
            _output.WriteLine("{");
            _output.IncreaseIndent();

            //Note:Simple lambda always have 1 line code, so add prefix ident and postfix ';'
            if (node.Body.Kind() != SyntaxKind.Block)
                _output.Write(string.Empty);
            if (info.DelegateReturnValue())
                _output.Write("return ");
            this.Visit(node.Body);
            if (node.Body.Kind() != SyntaxKind.Block)
                _output.WriteLine(";");

            _output.DecreaseIndent();
            _output.Write('}');

            return node;
        }

        public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            var info = _semanticModel.GetTypeInfo(node);

            _output.Write("function ({0}) ", this.MakeParametersList(node.ParameterList));
            _output.WriteLine("{");
            _output.IncreaseIndent();
            if (node.Body.Kind() != SyntaxKind.Block)
            {
                _output.Write(string.Empty);
                if (info.DelegateReturnValue())
                    _output.Write("return ");
            }
            this.Visit(node.Body);
            if (node.Body.Kind() != SyntaxKind.Block)
            {
                _output.WriteLine(";");
            }
            _output.DecreaseIndent();
            _output.Write('}');
            return node;
        }

        public override SyntaxNode VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            //Note: because we can not predict what T is, unless there is constraint on T said it's class or struct.
            this.AppendCompileIssue(node, IssueType.Warning, IssueId.DefaultKeyword);
            _output.Write("null");

            return node;
        }

        public override SyntaxNode VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.TypeOfNotSupport);
            return node;
        }

        public override SyntaxNode VisitSizeOfExpression(SizeOfExpressionSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.SizeOfNotSupport);
            return node;
        }

        private bool _isAssignLeft;
        public override SyntaxNode VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            if (node.Right.Kind().IsAssignment())
            {
                this.AppendCompileIssue(node, IssueType.Warning, IssueId.MultiAssignment);
            }

            if (IsPropertyAccess(node.Left))
            {
                if (node.OperatorToken.Kind() != SyntaxKind.EqualsToken)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.PropertyAccessIssue);
                }
                _isAssignLeft = true;
                this.Visit(node.Left);
                _isAssignLeft = false;
                _output.Write('(');
                this.Visit(node.Right);
                _output.Write(')');
            }
            else
            {
                this.Visit(node.Left);
                _output.Write(" {0} ", node.OperatorToken);
                this.Visit(node.Right);
            }

            return node;
        }
    }
}
