using System;
using SOLID.DIP.After.Exceptions;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Parsers;
using SOLID.DIP.After.Parsers.Interfaces;

namespace SOLID.DIP.After.Processors
{
    public class ImportantIssueStatisticsProcessor
    {
        public DateTime StatisticsDateTime { get; private set; }

        private readonly IIssueReportParser _issueReportParser;
        private readonly IDateTimeFacade _dateTimeFacade;
        private readonly IIssueStatisticsWriter _issueStatisticsWriter;

        public ImportantIssueStatisticsProcessor()
        {
            _issueReportParser = new IssueReportParserImportantIssueFilter(new IssueReportParser());
            _dateTimeFacade = new DateTimeFacade();
            _issueStatisticsWriter = new IssueStatisticsWriter();
        }

        public ImportantIssueStatisticsProcessor(
            IIssueReportParser issueReportParser,
            IDateTimeFacade dateTimeFacade,
            IIssueStatisticsWriter issueStatisticsWriter)
        {
            _issueReportParser = issueReportParser;
            _dateTimeFacade = dateTimeFacade;
            _issueStatisticsWriter = issueStatisticsWriter;
        }

        public void Process(IssueTypes issueType, string statisticsFileName)
        {
            if (issueType != IssueTypes.Errors)
            {
                throw new IssueTypeNotImportantException($"'{issueType}' issues type is not important.");
            }

            var issueReport = _issueReportParser.Parse(issueType);
            if (issueReport != null)
            { 
                StatisticsDateTime = _dateTimeFacade.Now;

                _issueStatisticsWriter.Write(statisticsFileName, issueType, issueReport.Issues.Count);
            }
        }
    }
}
