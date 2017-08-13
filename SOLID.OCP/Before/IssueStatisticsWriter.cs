using System.IO;
using SOLID.OCP.Before.Models;

namespace SOLID.OCP.Before
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
