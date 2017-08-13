using System;
using SOLID.ISP.Before.Models;
using SOLID.ISP.Before.Parsers;

namespace SOLID.ISP.Before.Processors
{
    public class IssueStatisticsProcessor
    {
        public DateTime StatisticsDateTime { get; protected set; }

        public virtual void Process(IssueTypes issueType, string statisticsFileName)
        {
            var issueReport = new IssueReportParser().Parse(issueType);

            if (StatisticsDateTime == default(DateTime))
            {
                StatisticsDateTime = DateTime.Now;
            }

            new IssueStatisticsWriter().Write(statisticsFileName, issueType, issueReport.Issues.Count);
        }
    }
}
