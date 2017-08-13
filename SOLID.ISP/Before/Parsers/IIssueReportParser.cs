using SOLID.ISP.Before.Models;

namespace SOLID.ISP.Before.Parsers
{
    public interface IIssueReportParser
    {
        IssueReport Parse(IssueTypes issueType);

        IssueReport TryParse(IssueTypes issueType);
    }
}