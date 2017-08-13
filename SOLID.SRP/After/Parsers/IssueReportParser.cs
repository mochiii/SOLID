using System.Xml;

namespace SOLID.SRP.After.Parsers
{
    public class IssueReportParser
    {
        private const string ErrorReportFileName = "errors.xml";

        public ErrorReport Parse()
        {
            var rawErrorReport = new XmlDocument();
            rawErrorReport.LoadXml(ErrorReportFileName);

            var errorReport = new ErrorReport
            {
                DateTime = new IssueReportDateTimeParser().Parse(rawErrorReport),
                Errors = new IssueReportIssueParser().Parse(rawErrorReport)
            };

            return errorReport;
        }
    }
}
