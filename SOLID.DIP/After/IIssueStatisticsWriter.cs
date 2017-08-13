using SOLID.DIP.After.Models;

namespace SOLID.DIP.After
{
    public interface IIssueStatisticsWriter
    {
        void Write(string statisticsFileName, IssueTypes issueType, int issueCount);
    }
}