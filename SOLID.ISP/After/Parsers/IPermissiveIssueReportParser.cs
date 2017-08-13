using SOLID.ISP.After.Models;

namespace SOLID.ISP.After.Parsers
{
    public interface IPermissiveIssueReportParser
    {
        IssueReport TryParse(IssueTypes issueType);
    }
}
