using SOLID.DIP.Before.Models;
using SOLID.DIP.Before.Parsers;

namespace SOLID.DIP.Before
{
    public class IssueReportParserImportantIssueFilter : IIssueReportParser
    {
        private const int IssueImportanceThreshold = 10;

        private readonly IssueReportParser _issueReportParser;

        public IssueReportParserImportantIssueFilter(IssueReportParser issueReportParser)
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