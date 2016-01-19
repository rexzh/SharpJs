using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using SJC.Compiler.Template;

using RexToy;

namespace SJC.Compiler
{
    partial class Rewriter
    {
        /// <summary>
        /// when generating static member in a non-static class, need set this flag.
        /// </summary>
        private bool _isStaticMember = false;

        //Note:It must exist, to shortcut visit the using [XXX], otherwise it will visit XXX
        public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (node.Alias != null)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UsingAliasNotSupport);
            }
            else
            {
                if (_template.SupportUsing)
                {
                    var template = _template.CreateUsingTemplate();
                    _output.Write(node, template.GetBeginString());
                    this.Visit(node.Name);
                    _output.TrivialWriteLine(template.GetEndString());
                }
            }
            return node;
        }

        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            string ns = node.Name.ToFullString();//TODO:More thorough visit
            var template = _template.CreateNamespaceTemplate();
            template.Assign(NamespaceTemplate.NAMESPACE, ns);
            if (!RegisteredNamespace.Contains(ns))
            {
                _output.WriteLine(node.Name, template.GetBeginString());
            }

            foreach (var member in node.Members)
            {
                var info = _semanticModel.GetDeclaredSymbol(member);
                if (info.IsNoCompile())
                    continue;

                this.Visit(member);
            }

            if (!RegisteredNamespace.Contains(ns))
            {
                _output.TrivialWriteLine(template.GetEndString());
                RegisteredNamespace.Add(ns);
            }

            return node;
        }

        private string _currentClass;
        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (node.IsUnSafe())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UnsafeNotSupport);
                return node;
            }

            var ctorInfos = this._semanticModel.GetDeclaredSymbol(node).InstanceConstructors;
            if (ctorInfos.Count() > 1)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.CtorOverload);
                return node;
            }

            bool isStaticType = false;
            if (node.IsPartial())
                this.AppendCompileIssue(node, IssueType.Error, IssueId.PartialNotSupport);
            if (node.IsStaticType())
                isStaticType = true;

            List<MemberDeclarationSyntax> static_members = new List<MemberDeclarationSyntax>();

            var classInfo = this._semanticModel.GetDeclaredSymbol(node);
            _currentClass = classInfo.GetTypeSymbolName();

            int total = 0;//Note:Total member count, calc in below loop.
            foreach (var m in node.Members)
            {
                if (m.Kind() == SyntaxKind.PropertyDeclaration)
                {
                    this.AppendCompileIssue(m, IssueType.Error, IssueId.PropertyDeclareNotSupport);
                    continue;
                }

                if (m.IsValidMemberKind() && (m.IsStaticMember() || _semanticModel.IsGlobalVariable(m)))
                    continue;

                if (m.Kind() == SyntaxKind.FieldDeclaration && _semanticModel.IsNoCompile((m as FieldDeclarationSyntax)))
                    continue;

                if (m.Kind() == SyntaxKind.MethodDeclaration && _semanticModel.IsNoCompile((m as MethodDeclarationSyntax)))
                    continue;

                total++;
            }

            int memberCount = 0;

            string strBaseClass;
            if (node.BaseList != null)
            {
                var baseInfo = classInfo.BaseType;
                if (!baseInfo.IsScriptSymbol())
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.UseNonScript, baseInfo);
                    return node;
                }

                if (baseInfo.ContainingNamespace.Name == nameof(System) && baseInfo.Name == nameof(System.Object))
                    strBaseClass = _template.RootType;
                else
                    strBaseClass = baseInfo.GetTypeSymbolName();
            }
            else
            {
                strBaseClass = _template.RootType;
            }

            string strInterfaces = this.MakeInterfacesList(node);

            BasicClassTemplate classTemplate = _template.CreateClassTemplate(isStaticType);

            classTemplate.Assign(BasicClassTemplate.CLASS, _currentClass).Assign("baseclass", strBaseClass).Assign("interfaces", strInterfaces);
            _output.Write(node.Identifier, classTemplate.GetBeginString());

            if (!isStaticType)
            {
                if (_indentType)
                    _output.IncreaseIndent();
            }

            foreach (var member in node.Members)
            {
                if (member.Kind() == SyntaxKind.PropertyDeclaration)
                {
                    //Note:Must skip for the member count reason.
                    continue;
                }

                if (member.Kind() == SyntaxKind.ClassDeclaration)
                {
                    this.AppendCompileIssue(member, IssueType.Error, IssueId.InnerClassNotSupport);
                    continue;
                }

                if (member.Kind() == SyntaxKind.ConstructorDeclaration)
                {
                    var ctorSyntax = member as ConstructorDeclarationSyntax;
                    if (ctorSyntax.IsStaticMember())
                        this.AppendCompileIssue(node, IssueType.Error, IssueId.StaticConstructor);
                }

                if (member.Kind() == SyntaxKind.FieldDeclaration)
                {
                    var field = member as FieldDeclarationSyntax;
                    if (_semanticModel.IsGlobalVariable(field) || _semanticModel.IsNoCompile(field))
                        continue;
                }

                if (member.Kind() == SyntaxKind.MethodDeclaration)
                {
                    var method = member as MethodDeclarationSyntax;
                    if (_semanticModel.IsNoCompile(method))
                        continue;
                }

                if ((!isStaticType) && member.IsStaticMember())//Note:IsValid will be true, other case is handled above
                {
                    //Note: Check if is EvalAtCompile field, no need to parse it here. Don't add to static_memebers.
                    if (member.Kind() != SyntaxKind.FieldDeclaration || !(_semanticModel.IsEvalCandidate(member)))
                    {
                        static_members.Add(member);
                    }
                }
                else
                {
                    _isStaticMember = member.IsStaticMember();
                    if (isStaticType)
                    {
                        _output.Write(member, _currentClass + ".");
                    }

                    this.Visit(member);
                    memberCount++;

                    if (isStaticType)
                        _output.TrivialWriteLine(';');
                    else if (memberCount != total)
                    {
                        _output.TrivialWriteLine(_template.MemberSeparator);
                        if (member.Kind() == SyntaxKind.MethodDeclaration || member.Kind() == SyntaxKind.ConstructorDeclaration || member.Kind() == SyntaxKind.PropertyDeclaration)
                        {
                            _output.TrivialWriteLine();
                        }
                    }
                    _isStaticMember = false;
                }
            }

            if (!isStaticType)
            {
                if (_indentType)
                    _output.DecreaseIndent();
            }
            _output.TrivialWriteLine();

            classTemplate.Assign(BasicClassTemplate.CLASS, _currentClass).Assign(BasicClassTemplate.BASECLASS, strBaseClass).Assign(BasicClassTemplate.INTERFACE, strInterfaces);
            _output.TrivialWrite(classTemplate.GetEndString());

            _output.TrivialWriteLine();//Note: Empty line after class declare.

            if (!isStaticType && static_members.Count > 0)
            {
                _isStaticMember = true;
                foreach (var member in static_members)
                {
                    _output.Write(member, _currentClass + ".");
                    Visit(member);
                    _output.TrivialWriteLine(';');
                }

                _output.TrivialWriteLine();
                _isStaticMember = false;
            }

            return node;
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            var info = _semanticModel.GetTypeInfo(node.Declaration.Type);
            if (!info.Type.IsScriptSymbol())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UseNonScript, info.Type);
            }

            if (node.Declaration.Variables.Count > 1)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.OneFieldOneLine, info.Type);
            }

            var v = node.Declaration.Variables[0];//Note:only have 1 var.
            string field = _semanticModel.GetMemberSymbolName(node);

            BasicFieldTemplate template = _template.CreateFieldTemplate(_isStaticMember);
            template.Assign(BasicFieldTemplate.FIELD, field);
            _output.Write(node, template.GetBeginString());

            if (v.Initializer == null)
            {
                var typeInfo = node.Declaration.Type;
                string defaultValue = _semanticModel.GetDefaultValueOfType(typeInfo);
                _output.TrivialWrite(defaultValue);
            }
            else
            {
                this.Visit(v.Initializer);
            }

            _output.TrivialWrite(template.GetEndString());
            return node;
        }

        private bool _isNative = false;
        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            if (_isNative)
            {
                OutputNativeMethod(node);

                if (node.Statements.Count != 0)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.NativeFormat);
                }
            }
            else
            {
                foreach (var stmt in node.Statements)
                {
                    this.Visit(stmt);
                    switch (stmt.Kind())
                    {
                        case SyntaxKind.ForEachStatement:
                        case SyntaxKind.ForStatement:
                        case SyntaxKind.IfStatement:
                        case SyntaxKind.TryStatement:
                        case SyntaxKind.WhileStatement:
                        case SyntaxKind.SwitchStatement:
                            _output.TrivialWriteLine();
                            break;

                        case SyntaxKind.BreakStatement:
                        case SyntaxKind.ContinueStatement:
                            break;

                        default:
                            _output.TrivialWriteLine(';');
                            break;
                    }
                }
            }
            return node;
        }

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.IsUnSafe())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UnsafeNotSupport);
                return node;
            }

            if (node.IsExtern())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.ExternNotSupport);
                return node;
            }

            var info = _semanticModel.GetDeclaredSymbol(node);
            _isNative = info.IsNativeMethod();

            var rInfo = _semanticModel.GetTypeInfo(node.ReturnType);
            if (!rInfo.Type.IsScriptSymbol())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UseNonScript, rInfo.Type);
            }

            BasicMethodTemplate template = _template.CreateMethodTemplate(_isStaticMember);
            template.Assign(BasicMethodTemplate.CLASS, _currentClass).Assign(BasicMethodTemplate.METHOD, info.GetMemberSymbolName()).Assign(BasicMethodTemplate.ARGS, this.MakeParametersList(node.ParameterList));
            _output.Write(node.Identifier, template.GetBeginString());

            if (_indentMember)
                _output.IncreaseIndent();

            if (node.Body != null)
                this.VisitBlock(node.Body);

            if (node.ExpressionBody != null)
            {
                if (!_semanticModel.IsVoid(node))
                    _output.Write(node.ExpressionBody, "return ");
                this.Visit(node.ExpressionBody);

                _output.TrivialWriteLine(';');
            }

            if (_indentMember)
                _output.DecreaseIndent();

            _output.TrivialWrite(template.GetEndString());

            this._isNative = false;
            return node;
        }

        public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            if (_template.SupportCtor)
            {
                var template = _template.CreateConstructorTemplate();
                template.Assign(ConstructorTemplate.ARGS, this.MakeParametersList(node.ParameterList));
                _output.Write(node, template.GetBeginString());

                _output.IncreaseIndent();
                this.Visit(node.Body);
                _output.DecreaseIndent();

                _output.TrivialWrite(template.GetEndString());
            }
            else
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.CtorNotSupport, _template.Name);
            }

            return node;
        }

        public override SyntaxNode VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            var info = _semanticModel.GetTypeInfo(node.Declaration.Type);
            if (!info.Type.IsScriptSymbol())
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.UseNonScript, info.Type);
            }

            _output.TrivialWrite("var ");
            this.MakeLocalVariableList(node.Declaration);

            return node;
        }

        public override SyntaxNode VisitForStatement(ForStatementSyntax node)
        {
            _output.Write(node.ForKeyword, "for (");

            if (node.Initializers != null)
            {
                this.MakeExpressionList(node.Initializers);
            }

            if (node.Declaration != null)
            {
                _output.TrivialWrite("var ");
                this.MakeLocalVariableList(node.Declaration);
            }

            _output.TrivialWrite("; ");

            this.VisitExpression(node.Condition);
            _output.TrivialWrite("; ");

            this.MakeExpressionList(node.Incrementors);

            _output.TrivialWriteLine(") {");

            _output.IncreaseIndent();
            this.Visit(node.Statement);
            this.AppendCompensateSemicolon(node.Statement);
            _output.DecreaseIndent();

            _output.TrivialWrite('}');
            return node;
        }

        public override SyntaxNode VisitForEachStatement(ForEachStatementSyntax node)
        {
            var info = this._semanticModel.GetTypeInfo(node.Expression);

            if (info.IsEnumerable())
            {
                //Note:Here we use __idx${identifierName} as index
                _output.Write(node.ForEachKeyword, "for (var __idx${0} = 0; __idx${0} < ", node.Identifier.ValueText);
                VisitExpression(node.Expression);
                _output.Write(node.Identifier, ".length; __idx${0}++) ", node.Identifier.ValueText);
                _output.TrivialWriteLine('{');

                _output.IncreaseIndent();
                _output.Write(node.Identifier, "var {0} = ", node.Identifier.ValueText);
                Visit(node.Expression);
                _output.WriteLine(node.Identifier, "[__idx${0}];", node.Identifier.ValueText);

                this.Visit(node.Statement);
                this.AppendCompensateSemicolon(node.Statement);
                _output.DecreaseIndent();
                _output.TrivialWrite('}');
            }
            else
            {
                _output.Write(node.ForEachKeyword, "for (var {0} in ", node.Identifier.ValueText);
                VisitExpression(node.Expression);
                _output.TrivialWriteLine(") {");

                _output.IncreaseIndent();
                this.Visit(node.Statement);
                this.AppendCompensateSemicolon(node.Statement);
                _output.DecreaseIndent();

                _output.TrivialWrite('}');
            }

            return node;
        }

        public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
        {
            _output.Write(node.WhileKeyword, "while (");
            this.VisitExpression(node.Condition);
            _output.TrivialWriteLine(") {");

            _output.IncreaseIndent();
            this.Visit(node.Statement);
            this.AppendCompensateSemicolon(node.Statement);
            _output.DecreaseIndent();

            _output.TrivialWrite('}');
            return node;
        }

        public override SyntaxNode VisitDoStatement(DoStatementSyntax node)
        {
            _output.WriteLine(node.DoKeyword, "do {");

            _output.IncreaseIndent();
            Visit(node.Statement);
            this.AppendCompensateSemicolon(node.Statement);
            _output.DecreaseIndent();

            _output.Write(node.WhileKeyword, "} while (");
            VisitExpression(node.Condition);
            _output.TrivialWrite(')');
            return node;
        }

        public override SyntaxNode VisitIfStatement(IfStatementSyntax node)
        {
            _output.Write(node.IfKeyword, "if ( ");
            this.VisitExpression(node.Condition);
            _output.TrivialWriteLine(" ) {");

            _output.IncreaseIndent();
            this.Visit(node.Statement);
            this.AppendCompensateSemicolon(node.Statement);
            _output.DecreaseIndent();

            _output.TrivialWrite('}');
            if (node.Else != null)
            {
                _output.WriteLine(node.Else.ElseKeyword, " else {");

                _output.IncreaseIndent();
                this.Visit(node.Else.Statement);
                this.AppendCompensateSemicolon(node.Else.Statement);
                _output.DecreaseIndent();

                _output.TrivialWrite('}');
            }
            _output.TrivialWriteLine();
            return node;
        }

        public override SyntaxNode VisitBreakStatement(BreakStatementSyntax node)
        {
            _output.WriteLine(node.BreakKeyword, "break;");
            return node;
        }

        public override SyntaxNode VisitContinueStatement(ContinueStatementSyntax node)
        {
            _output.WriteLine(node.ContinueKeyword, "continue;");
            return node;
        }

        public override SyntaxNode VisitTryStatement(TryStatementSyntax node)
        {
            _output.WriteLine(node.TryKeyword, "try {");

            _output.IncreaseIndent();
            this.Visit(node.Block);
            _output.DecreaseIndent();

            _output.TrivialWrite('}');

            string catchedName = null;
            if (node.Catches.Count > 0)
            {
                foreach (var c in node.Catches)
                {
                    if (c.Filter != null)
                        this.AppendCompileIssue(c, IssueType.Error, IssueId.ExceptionFilter);

                    if (c.Declaration != null)
                    {
                        var id = c.Declaration.Identifier;
                        if (id != null && id.Kind() != SyntaxKind.None)
                        {
                            if (string.IsNullOrEmpty(catchedName))
                                catchedName = id.ValueText;
                            else
                            {
                                if (catchedName != id.ValueText)
                                    this.AppendCompileIssue(node, IssueType.Error, IssueId.CatchSameName);
                            }
                        }
                    }
                }


                _output.WriteLine(node.Catches[0], " catch (" + (catchedName ?? "e") + ") {");
                _output.IncreaseIndent();
                if (node.Catches.Count == 1)
                {
                    this.Visit(node.Catches[0].Block);
                }
                else
                {
                    var count = 0;
                    for (int i = 0; i < node.Catches.Count; i++)
                    {
                        if (count > 0)
                            _output.Write(node.Catches[i].CatchKeyword, " else ");

                        var c = node.Catches[i];
                        if (c.Declaration != null)
                        {
                            var info = _semanticModel.GetSymbolInfo(c.Declaration.Type);
                            var typename = info.Symbol.GetTypeSymbolName();

                            if (count == 0)
                                _output.Write(c.Declaration, "if ({0}.name == \"{1}\") ", catchedName, typename);
                            else
                                _output.Write(c.Declaration, "if ({0}.name == \"{1}\") ", catchedName, typename);
                            _output.TrivialWriteLine('{');
                            _output.IncreaseIndent();
                            this.Visit(c.Block);
                            _output.DecreaseIndent();
                            _output.TrivialWrite('}');
                        }
                        else
                        {
                            _output.TrivialWriteLine('{');
                            _output.IncreaseIndent();
                            this.Visit(c.Block);
                            _output.DecreaseIndent();
                            _output.TrivialWrite('}');
                        }

                        count++;
                    }
                }
                if (node.Catches.Count > 1)
                    _output.TrivialWriteLine();
                _output.DecreaseIndent();
                _output.TrivialWrite('}');
            }

            if (node.Finally != null)
            {
                _output.WriteLine(node.Finally.FinallyKeyword, " finally {");

                _output.IncreaseIndent();
                this.Visit(node.Finally.Block);
                _output.DecreaseIndent();

                _output.TrivialWrite('}');
            }

            return node;
        }

        public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
        {
            if (node.Expression != null)
            {
                _output.Write(node.ReturnKeyword, "return ");
                this.VisitExpression(node.Expression);
            }
            else
            {
                _output.Write(node.ReturnKeyword, "return");
            }

            return node;
        }

        public override SyntaxNode VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            this.Visit(node.Expression);
            return node;
        }

        public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
        {
            _output.Write(node.SwitchKeyword, "switch (");
            this.Visit(node.Expression);
            _output.TrivialWriteLine(") {");
            _output.IncreaseIndent();

            foreach (var section in node.Sections)
            {
                foreach (var lbl in section.Labels)
                {
                    _output.Write(lbl.Keyword, lbl.Keyword.ValueText);
                    if (lbl.Keyword.Kind() == SyntaxKind.CaseKeyword)
                    {
                        _output.TrivialWrite(' ');
                        var caseLbl = lbl as CaseSwitchLabelSyntax;
                        this.VisitExpression(caseLbl.Value);
                    }
                    _output.TrivialWriteLine(':');
                }

                _output.IncreaseIndent();

                foreach (var stmt in section.Statements)
                {
                    Visit(stmt);

                    switch (stmt.Kind())
                    {
                        case SyntaxKind.ExpressionStatement:
                        case SyntaxKind.LocalDeclarationStatement:
                        case SyntaxKind.ReturnStatement:
                        case SyntaxKind.ThrowStatement:
                            _output.TrivialWriteLine(';');
                            break;
                    }
                }
                _output.DecreaseIndent();
            }

            _output.DecreaseIndent();
            _output.TrivialWriteLine('}');

            return node;
        }

        public override SyntaxNode VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            this.VisitExpression(node.Value);
            return node;
        }

        public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            if (!_template.SupportInterface)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.InterfaceNotSupport, _template.Name);
                return node;
            }
            else
            {
                var interfaceInfo = this._semanticModel.GetDeclaredSymbol(node);

                string strInterface = interfaceInfo.GetTypeSymbolName();

                var interfaceTemplate = _template.CreateInterfaceTemplate();
                interfaceTemplate.Assign("interface", strInterface);
                _output.Write(node, interfaceTemplate.GetBeginString());

                if (_indentType)
                    _output.IncreaseIndent();

                var count = 0;
                foreach (var member in node.Members)
                {
                    Visit(member);
                    count++;
                    if (count != node.Members.Count)
                        _output.TrivialWriteLine(',');
                }

                if (_indentType)
                    _output.DecreaseIndent();

                _output.TrivialWrite(interfaceTemplate.GetEndString());
                if (node.BaseList != null)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.InterfaceInheritNotSupport);
                }
            }
            return node;
        }

        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (!_template.SupportEnum)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.EnumNotSupport, _template.Name);
            }
            else
            {
                var info = _semanticModel.GetDeclaredSymbol(node);
                string enumName = info.GetTypeSymbolName();

                var enumTemplate = _template.CreateEnumTemplate();
                enumTemplate.Assign("enum", enumName);
                _output.Write(node, enumTemplate.GetBeginString());

                _output.IncreaseIndent();
                var count = 0;
                foreach (var member in node.Members)
                {
                    Visit(member);
                    count++;
                    if (count != node.Members.Count)
                    {
                        _output.TrivialWriteLine(',');
                    }
                }
                _output.DecreaseIndent();

                _output.TrivialWriteLine(enumTemplate.GetEndString());

                if (node.BaseList != null)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.EnumInheritNotSupport);
                }
            }
            return node;
        }

        public override SyntaxNode VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.ConverterOperatorNotSupport);
            return node;
        }

        public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
        {
            //Note:Event with body(add/remove method)
            //Extend:May add support depend on template, e.g. enyo
            this.AppendCompileIssue(node, IssueType.Error, IssueId.EventNotSupport);
            return node;
        }

        public override SyntaxNode VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            //Note:Simple Event declare(no body)
            //Extend:May add support depend on template, e.g. enyo
            this.AppendCompileIssue(node, IssueType.Error, IssueId.EventNotSupport);
            return node;
        }

        public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            //Extend:Maybe add support depend on template, e.g. MS Ajax
            return node;
        }

        public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.DestructorNotSupport);
            return node;
        }

        public override SyntaxNode VisitGotoStatement(GotoStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.GotoNotSupport);
            return node;
        }

        public override SyntaxNode VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.IndexerNotSupport);
            return node;
        }

        public override SyntaxNode VisitLockStatement(LockStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.LockNotSupport);
            return node;
        }

        public override SyntaxNode VisitCheckedExpression(CheckedExpressionSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.CheckedNotSupport);
            return node;
        }

        public override SyntaxNode VisitCheckedStatement(CheckedStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.CheckedNotSupport);
            return node;
        }

        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.StructNotSupport);
            return node;
        }

        public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.UnsafeNotSupport);
            return node;
        }

        public override SyntaxNode VisitUsingStatement(UsingStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.UsingNotSupport);
            return node;
        }

        public override SyntaxNode VisitYieldStatement(YieldStatementSyntax node)
        {
            this.AppendCompileIssue(node, IssueType.Error, IssueId.YieldNotSupport);
            return node;
        }

        public override SyntaxNode VisitThrowStatement(ThrowStatementSyntax node)
        {
            if (node.Expression == null)
            {
                this.AppendCompileIssue(node, IssueType.Error, IssueId.ThrowNothing);
            }
            else
            {
                _output.Write(node.ThrowKeyword, "throw ");
                Visit(node.Expression);
            }
            return node;
        }

        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            _output.Write(node.Identifier, node.Identifier.ValueText);
            _output.TrivialWrite(": ");
            var info = _semanticModel.GetDeclaredSymbol(node);
            string val;
            bool hasAttr = info.GetEnumValue(out val);

            if (node.EqualsValue != null)
            {
                if (hasAttr)
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.EnumFieldTwoValue);
                }
                else
                {
                    Visit(node.EqualsValue.Value);
                }
            }
            else
            {
                if (hasAttr)
                {
                    _output.Write(node, val);
                }
                else
                {
                    this.AppendCompileIssue(node, IssueType.Error, IssueId.EnumFieldNoValue, node);
                }
            }

            return node;
        }
    }
}
