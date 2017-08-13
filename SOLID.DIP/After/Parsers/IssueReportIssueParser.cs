using System.Collections.Generic;
using System.Xml;
using SOLID.DIP.After.Exceptions;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Parsers.Interfaces;
using SOLID.DIP.After.Providers;

namespace SOLID.DIP.After.Parsers
{
    public class IssueReportIssueParser : IIssueReportIssueParser
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
