using System.IO;
using SOLID.DIP.Before.Models;

namespace SOLID.DIP.Before
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
