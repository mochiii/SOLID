using System;
using SOLID.LSP.After.Exceptions;
using SOLID.LSP.After.Models;
using SOLID.LSP.After.Parsers;

namespace SOLID.LSP.After.Processors
{
    public class ImportantIssueStatisticsProcessor
    {
        public DateTime StatisticsDateTime { get; private set; }

        public void Process(IssueTypes issueType, string statisticsFileName)
        {
            if (issueType != IssueTypes.Errors)
            {
                throw new IssueTypeNotImportantException($"'{issueType}' issues type is not important.");
            }

            var issueReport = new IssueReportParserImportantIssueFilter(new IssueReportParser()).Parse(issueType);
            if (issueReport != null)
            { 
                StatisticsDateTime = DateTime.Now;

                new IssueStatisticsWriter().Write(statisticsFileName, issueType, issueReport.Issues.Count);
            }
        }
    }
}
