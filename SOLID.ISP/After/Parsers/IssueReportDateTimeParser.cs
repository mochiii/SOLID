using System;
using System.Xml;
using SOLID.ISP.After.Exceptions;

namespace SOLID.ISP.After.Parsers
{
    public class IssueReportDateTimeParser
    {
        private const string DateTimeTag = "DateTime";

        public DateTime Parse(XmlDocument rawIssueReport)
        {
            var rawReportDateTime = rawIssueReport[DateTimeTag]?.InnerText;
            if (rawReportDateTime == null)
            {
                throw new ElementNotFoundException($"{DateTimeTag} element was not found in source xml report.");
            }

            var parsedDateTime = DateTime.Parse(rawReportDateTime);
            return parsedDateTime;
        }
    }
}
