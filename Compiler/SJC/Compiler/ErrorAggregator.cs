using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SJC.StdErr;

namespace SJC.Compiler
{
    public class ErrorAggregator
    {
        private List<CompileIssue> _issues;

        public bool HasError
        {
            get
            {
                var q = from issue in _issues
                        where issue.IssueType == IssueType.Error
                        select issue;
                return q.Count() > 0;
            }
        }

        public IEnumerable<CompileIssue> Errors
        {
            get
            {
                var q = from issue in _issues
                        where issue.IssueType == IssueType.Error
                        select issue;
                return q;
            }
        }

        public IEnumerable<CompileIssue> Warnings
        {
            get
            {
                var q = from issue in _issues
                        where issue.IssueType == IssueType.Warning
                        select issue;
                return q;
            }
        }

        /// <summary>
        /// Both Warning and Error
        /// </summary>
        public IEnumerable<CompileIssue> Issues
        {
            get
            {
                return _issues;
            }
        }

        private IEnumerable<int> _suppressNos;
        public ErrorAggregator(IEnumerable<int> suppressNos)
        {
            _suppressNos = suppressNos;
            _issues = new List<CompileIssue>();
        }

        public void AppendIssue(CompileIssue issue)
        {
            if (issue.IssueType == IssueType.Warning && _suppressNos.Contains(issue.IssueId))//Note:Only suppress warning
                return;

            _issues.Add(issue);
        }

        public void WriteToStdErr(IOutput output)
        {
            string msg = $"{Constants.SharpJs} compile finish. {this.Errors.Count()} error(s), {this.Warnings.Count()} warning(s)";
            if (this.HasError)
            {
                output.Error(msg, true);
            }
            else
            {
                output.Success(msg, true);
            }

            foreach (var warn in this.Warnings)
            {
                output.Warning(warn.Message);
            }

            foreach (var err in this.Errors)
            {
                output.Error(err.Message);
            }
        }
    }
}
