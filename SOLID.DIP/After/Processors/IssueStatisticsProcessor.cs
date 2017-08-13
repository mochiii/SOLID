using System;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Parsers;
using SOLID.DIP.After.Parsers.Interfaces;

namespace SOLID.DIP.After.Processors
{
    public class IssueStatisticsProcessor
    {
        public DateTime StatisticsDateTime { get; protected set; }

        private readonly IIssueReportParser _issueReportParser;
        private readonly IDateTimeFacade _dateTimeFacade;
        private readonly IIssueStatisticsWriter _issueStatisticsWriter;

        public IssueStatisticsProcessor()
        {
            _issueReportParser = new IssueReportParser();
            _dateTimeFacade = new DateTimeFacade();
            _issueStatisticsWriter = new IssueStatisticsWriter();
        }

        public IssueStatisticsProcessor(
            IIssueReportParser issueReportParser,
            IDateTimeFacade dateTimeFacade,
            IIssueStatisticsWriter issueStatisticsWriter)
        {
            _issueReportParser = issueReportParser;
            _dateTimeFacade = dateTimeFacade;
            _issueStatisticsWriter = issueStatisticsWriter;
        }

        public virtual void Process(IssueTypes issueType, string statisticsFileName)
        {
            var issueReport = _issueReportParser.Parse(issueType);

            if (StatisticsDateTime == default(DateTime))
            {
                StatisticsDateTime = _dateTimeFacade.Now;
            }

            _issueStatisticsWriter.Write(statisticsFileName, issueType, issueReport.Issues.Count);
        }
    }
}
