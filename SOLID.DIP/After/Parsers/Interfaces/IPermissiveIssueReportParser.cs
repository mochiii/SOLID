using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Parsers.Interfaces
{
    public interface IPermissiveIssueReportParser
    {
        IssueReport TryParse(IssueTypes issueType);
    }
}
