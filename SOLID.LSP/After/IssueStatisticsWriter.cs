using System.IO;
using SOLID.LSP.After.Models;

namespace SOLID.LSP.After
{
    public class IssueStatisticsWriter
    {
        public void Write(string statisticsFileName, IssueTypes issueType, int issueCount)
        {
            using (var statisticsWriter = new StreamWriter(statisticsFileName))
            {
                statisticsWriter.WriteLine($"Found {issueCount} {issueType.ToString().ToLower()} in report.");
            }
        }
    }
}
