using System;
using SOLID.LSP.After.Models;
using SOLID.LSP.After.Parsers;

namespace SOLID.LSP.After.Processors
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
