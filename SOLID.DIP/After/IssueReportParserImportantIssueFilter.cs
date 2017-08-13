using SOLID.DIP.After.Models;
using SOLID.DIP.After.Parsers.Interfaces;

namespace SOLID.DIP.After
{
    public class IssueReportParserImportantIssueFilter : IIssueReportParser
    {
        private const int IssueImportanceThreshold = 10;

        private readonly IIssueReportParser _issueReportParser;

        public IssueReportParserImportantIssueFilter(IIssueReportParser issueReportParser)
        {
            _issueReportParser = issueReportParser;
        }

        public IssueReport Parse(IssueTypes issueType)
        {
            var issueReport = _issueReportParser.Parse(issueType);

            return issueReport.Issues.Count > IssueImportanceThreshold ? issueReport : null;
        }
    }
}