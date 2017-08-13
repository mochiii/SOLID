using System;
using SOLID.SRP.After.Parsers;

namespace SOLID.SRP.After
{
    public class IssueStatisticsProcessor
    {
        public DateTime StatisticsDateTime { get; protected set; }

        public virtual void Process(string statisticsFileName)
        {
            var errorReport = new IssueReportParser().Parse();

            if (StatisticsDateTime == default(DateTime))
            {
                StatisticsDateTime = DateTime.Now;
            }

            new IssueStatisticsWriter().Write(statisticsFileName, errorReport.Errors.Count);
        }
    }
}
