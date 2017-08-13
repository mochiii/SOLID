using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Parsers.Interfaces
{
    public interface IIssueReportParser
    {
        IssueReport Parse(IssueTypes issueType);
    }
}