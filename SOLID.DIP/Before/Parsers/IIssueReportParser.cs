using SOLID.DIP.Before.Models;

namespace SOLID.DIP.Before.Parsers
{
    public interface IIssueReportParser
    {
        IssueReport Parse(IssueTypes issueType);
    }
}