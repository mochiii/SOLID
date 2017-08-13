using System.Collections.Generic;
using System.Xml;
using SOLID.OCP.Before.Exceptions;
using SOLID.OCP.Before.Models;

namespace SOLID.OCP.Before.Parsers
{
    public class IssueReportIssueParser
    {
        public List<IIssue> Parse(XmlDocument rawIssueReport, IssueTypes issueType)
        {
            string issueTag;

            switch (issueType)
            {
                case IssueTypes.Errors:
                    issueTag = "Error";
                    break;
                case IssueTypes.Warnings:
                    issueTag = "Warning";
                    break;

                default: throw new IssueTypeNotSupportedException($"'{issueType}' issues type is not supported.");
            }

            var issues = new List<IIssue>();

            var rawIssues = rawIssueReport.GetElementsByTagName(issueTag);
            for (var issueIndex = 0; issueIndex < rawIssues.Count; issueIndex++)
            {
                var issueMessage = rawIssues[issueIndex].InnerText;
                if (string.IsNullOrWhiteSpace(issueMessage))
                {
                    throw new ElementIsEmptyException($"{issueTag} element is empty in source xml report.");
                }

                var issue = issueType == IssueTypes.Errors ? (IIssue) new Error() : new Warning();
                issue.Message = issueMessage;

                issues.Add(issue);
            }

            return issues;
        }
    }
}
