using System;
using System.Xml;
using SOLID.DIP.After.Exceptions;
using SOLID.DIP.After.Parsers.Interfaces;

namespace SOLID.DIP.After.Parsers
{
    public class IssueReportDateTimeParser : IIssueReportDateTimeParser
    {
        private const string DateTimeTag = "DateTime";

        private readonly IDateTimeFacade _dateTimeFacade;

        public IssueReportDateTimeParser()
        {
            _dateTimeFacade = new DateTimeFacade();                
        }

        public IssueReportDateTimeParser(IDateTimeFacade dateTimeFacade)
        {
            _dateTimeFacade = dateTimeFacade;
        }

        public DateTime Parse(XmlDocument rawIssueReport)
        {
            var rawReportDateTime = rawIssueReport[DateTimeTag]?.InnerText;
            if (rawReportDateTime == null)
            {
                throw new ElementNotFoundException($"{DateTimeTag} element was not found in source xml report.");
            }

            var parsedDateTime = _dateTimeFacade.Parse(rawReportDateTime);
            return parsedDateTime;
        }
    }
}
