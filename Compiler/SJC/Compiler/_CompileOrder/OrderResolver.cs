using System.Collections.Generic;

using Microsoft.CodeAnalysis;

namespace SJC.Compiler
{
    public static class OrderResolver
    {
        public static IList<SyntaxTree> Sort(Compilation c, ErrorAggregator aggregator)
        {
            List<SyntaxTreeRelationship> rawList = new List<SyntaxTreeRelationship>();

            foreach (var tree in c.SyntaxTrees)
            {
                SyntaxTreeRelationship relation = new SyntaxTreeRelationship(tree);
                SemanticModel model = c.GetSemanticModel(tree);
                TypeWalker w = new TypeWalker(model, relation);
                w.Visit(tree.GetRoot());
                rawList.Add(relation);
            }

            int max = rawList.Count;

            List<SyntaxTree> sortedList = new List<SyntaxTree>();

            for (int times = 0; times < max; times++)
            {
                for (var i = 0; i < rawList.Count; i++)
                {
                    if (IsIndependent(rawList, i))
                    {
                        sortedList.Add(rawList[i].Tree);
                        rawList.RemoveAt(i);
                    }
                }
            }

            if (rawList.Count > 0)
            {
                CompileIssue issue = CompileIssue.CreateNoLocationIssue(IssueType.Error, IssueId.CrossRef);
                aggregator.AppendIssue(issue);

                //Note:use original order. use sortedList will miss cross ref class.
                return rawList.ConvertAll(r => r.Tree);
            }

            return sortedList;
        }

        public static bool IsIndependent(List<SyntaxTreeRelationship> list, int idx)
        {
            var tree = list[idx];
            for (int i = 0; i < list.Count; i++)
            {
                if (i == idx)
                    continue;
                else
                {
                    if (tree.IsDependOn(list[i]))
                        return false;
                }
            }
            return true;
        }
    }
}
