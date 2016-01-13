using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using SJC.Artifacts;

namespace SJC.Compiler
{
    public partial class Rewriter : CSharpSyntaxRewriter
    {
        private SemanticModel _semanticModel;
        private IOutput _output;
        private CodeTemplate _template;
        private ErrorAggregator _aggregator;

        private bool _indentType = true;
        private bool _indentMember = true;

        public Rewriter(SemanticModel semanticModel, CodeTemplate template, IOutput output, ErrorAggregator aggregator)
        {
            this._semanticModel = semanticModel;
            this._output = output;
            this._template = template;
            this._aggregator = aggregator;

            this._indentType = _template.TypeIndent;
            this._indentMember = _template.MemberIndent;
        }

        private void AppendCompileIssue(SyntaxNode node, IssueType type, IssueId id, params object[] args)
        {
            var issue = CompileIssue.Create(this._semanticModel.SyntaxTree, node, type, id, args);
            _aggregator.AppendIssue(issue);
        }

        private void AppendCompileIssue(SyntaxToken token, IssueType type, IssueId id, params object[] args)
        {
            var issue = CompileIssue.Create(this._semanticModel.SyntaxTree, token, type, id, args);
            _aggregator.AppendIssue(issue);
        }
    }
}
