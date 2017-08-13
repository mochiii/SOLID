using SOLID.LSP.Before.Models;

namespace SOLID.LSP.Before.Parsers
{
    public class ImportantIssueIssueReportParser : IssueReportParser
    {
        private const int IssueImportanceThreshold = 10;

        public override IssueReport Parse(IssueTypes issueType)
        {
            var issueReport = base.Parse(issueType);

            return issueReport.Issues.Count > IssueImportanceThreshold ? issueReport : null;
        }
    }
}