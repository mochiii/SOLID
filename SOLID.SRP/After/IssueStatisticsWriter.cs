using System.IO;

namespace SOLID.SRP.After
{
    public class IssueStatisticsWriter
    {
        public void Write(string statisticsFileName, int errorCount)
        {
            using (var statisticsWriter = new StreamWriter(statisticsFileName))
            {
                statisticsWriter.WriteLine($"Found {errorCount} errors in report.");
            }
        }
    }
}
