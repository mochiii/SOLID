using SOLID.LSP.After.Models;
using SOLID.LSP.After.Parsers;

namespace SOLID.LSP.After
{
    public class IssueReportParserImportantIssueFilter
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