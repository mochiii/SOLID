using SOLID.DIP.Before.Models;

namespace SOLID.DIP.Before.Parsers
{
    public interface IPermissiveIssueReportParser
    {
        IssueReport TryParse(IssueTypes issueType);
    }
}
