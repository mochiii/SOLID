using System;
using SOLID.LSP.Before.Exceptions;
using SOLID.LSP.Before.Models;
using SOLID.LSP.Before.Parsers;

namespace SOLID.LSP.Before.Processors
{
    public class ImportantIssueStatisticsProcessor : IssueStatisticsProcessor
    {
        public override void Process(IssueTypes issueType, string statisticsFileName)
        {
            if (issueType != IssueTypes.Errors)
            {
                throw new IssueTypeNotImportantException($"'{issueType}' issues type is not important.");
            }

            var issueReport = new ImportantIssueIssueReportParser().Parse(issueType);
            if (issueReport != null)
            { 
                StatisticsDateTime = DateTime.Now;

                new IssueStatisticsWriter().Write(statisticsFileName, issueType, issueReport.Issues.Count);
            }
        }
    }
}
