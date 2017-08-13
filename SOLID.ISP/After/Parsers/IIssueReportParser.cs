using SOLID.ISP.After.Models;

namespace SOLID.ISP.After.Parsers
{
    public interface IIssueReportParser
    {
        IssueReport Parse(IssueTypes issueType);
    }
}