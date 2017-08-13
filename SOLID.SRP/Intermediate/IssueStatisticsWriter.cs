using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using SOLID.SRP.Intermediate.Exceptions;

namespace SOLID.SRP.Intermediate
{
    public class IssueStatisticsWriter
    {
        private const string ErrorReportFileName = "errors.xml";
        private const string ErrorTag = "Error";
        private const string DateTimeTag = "DateTime";

        public DateTime StatisticsDateTime { get; protected set; }

        public void Write(string statisticsFileName)
        {
            var errorReport = ParseErrorReport();

            if (StatisticsDateTime == default(DateTime))
            {
                StatisticsDateTime = DateTime.Now;
            }

            WriteStatistics(statisticsFileName, errorReport.Errors.Count);
        }

        private ErrorReport ParseErrorReport()
        {
            var rawErrorReport = new XmlDocument();
            rawErrorReport.LoadXml(ErrorReportFileName);

            var rawReportDateTime = rawErrorReport[DateTimeTag]?.InnerText;
            if (rawReportDateTime == null)
            {
                throw new ElementNotFoundException($"{DateTimeTag} element was not found in source xml report.");
            }

            var errorReport = new ErrorReport
            {
                DateTime = DateTime.Parse(rawReportDateTime),
                Errors = new List<string>()
            };

            var errors = rawErrorReport.GetElementsByTagName(ErrorTag);
            for (var errorIndex = 0; errorIndex < errors.Count; errorIndex++)
            {
                var error = errors[errorIndex].InnerText;
                if (string.IsNullOrWhiteSpace(error))
                {
                    throw new ElementIsEmptyException($"{ErrorTag} element is empty in source xml report.");
                }

                errorReport.Errors.Add(error);
            }

            return errorReport;
        }

        private void WriteStatistics(string statisticsFileName, int errorCount)
        {
            using (var statisticsWriter = new StreamWriter(statisticsFileName))
            {
                statisticsWriter.WriteLine($"Found {errorCount} errors in report.");
            }
        }
    }
}
