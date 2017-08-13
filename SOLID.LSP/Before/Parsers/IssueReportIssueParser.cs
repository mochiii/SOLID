using System.Collections.Generic;
using System.Xml;
using SOLID.LSP.Before.Exceptions;
using SOLID.LSP.Before.Models;
using SOLID.LSP.Before.Providers;

namespace SOLID.LSP.Before.Parsers
{
    public class IssueReportIssueParser
    {
        public List<IIssue> Parse(XmlDocument rawIssueReport, IIssueInfoAndInstanceProvider issueInfoAndInstanceProvider)
        {
            var issues = new List<IIssue>();

            var rawIssues = rawIssueReport.GetElementsByTagName(issueInfoAndInstanceProvider.Tag);
            for (var issueIndex = 0; issueIndex < rawIssues.Count; issueIndex++)
            {
                var issueMessage = rawIssues[issueIndex].InnerText;
                if (string.IsNullOrWhiteSpace(issueMessage))
                {
                    throw new ElementIsEmptyException($"{issueInfoAndInstanceProvider.Tag} element is empty in source xml report.");
                }

                var issue = issueInfoAndInstanceProvider.ProvideInstance(issueMessage);

                issues.Add(issue);
            }

            return issues;
        }
    }
}
