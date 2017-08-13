using SOLID.DIP.After.Factories;
using SOLID.DIP.After.Factories.Interfaces;
using SOLID.DIP.After.Models;

namespace SOLID.DIP.After
{
    public class IssueStatisticsWriter : IIssueStatisticsWriter
    {
        private readonly IStreamWriterFactory _streamWriterFactory;

        public IssueStatisticsWriter()
        {
            _streamWriterFactory = new StreamWriterFactory();
        }

        public IssueStatisticsWriter(IStreamWriterFactory streamWriterFactory)
        {
            _streamWriterFactory = streamWriterFactory;
        }

        public void Write(string statisticsFileName, IssueTypes issueType, int issueCount)
        {
            using (var statisticsWriter = _streamWriterFactory.Create(statisticsFileName))
            {
                statisticsWriter.WriteLine($"Found {issueCount} {issueType.ToString().ToLower()} in report.");
            }
        }
    }
}
