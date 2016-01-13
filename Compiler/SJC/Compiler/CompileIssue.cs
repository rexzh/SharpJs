using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using RexToy;

namespace SJC.Compiler
{
    public enum IssueType
    {
        Warning,
        Error
    }

    public class CompileIssue
    {
        #region Factory method
        public static CompileIssue Create(SyntaxTree tree, SyntaxNode node, IssueType type, IssueId id, params object[] args)
        {
            IssueLocation loc = new IssueLocation(tree, node);
            CompileIssue issue = new CompileIssue(loc, type, id, args);
            return issue;
        }

        public static CompileIssue Create(SyntaxTree tree, SyntaxToken token, IssueType type, IssueId id, params object[] args)
        {
            IssueLocation loc = new IssueLocation(tree, token);
            CompileIssue issue = new CompileIssue(loc, type, id, args);
            return issue;
        }

        public static CompileIssue CreateNoLocationIssue(IssueType type, IssueId id, params object[] args)
        {
            CompileIssue issue = new CompileIssue(IssueLocation.NA, type, id, args);
            return issue;
        }
        #endregion

        private string _desc;
        private string _msg;
        public string Message
        {
            get
            {
                if (this._location == IssueLocation.NA)
                    return string.Format("{0}-{1}: {2}", Constants.SharpJs, IssueId.ToString("0000"), _msg);
                else
                    return string.Format("{0}-{1}: [{2}] {3}", Constants.SharpJs, IssueId.ToString("0000"), Location.ToString() , _msg);
            }
        }

        private IssueLocation _location;
        public IssueLocation Location
        {
            get { return _location; }
        }

        private CompileIssue(IssueLocation location, IssueType type, IssueId id)
        {
            this._id = id;
            this._issueType = type;
            _desc = id.GetDescription();
            _msg = _desc;
            _location = location;
        }

        private CompileIssue(IssueLocation location, IssueType type, IssueId id, params object[] args)
            : this(location, type, id)
        {
            _msg = _desc.TryFormat(args);
        }

        private IssueType _issueType;
        public IssueType IssueType
        {
            get { return _issueType; }
        }

        private IssueId _id;
        public int IssueId
        {
            get { return (int)_id; }
        }
    }
}
