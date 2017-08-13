using System.Xml;
using SOLID.OCP.Before.Exceptions;
using SOLID.OCP.Before.Models;

namespace SOLID.OCP.Before.Parsers
{
    public class IssueReportParser
    {
        public virtual IssueReport Parse(IssueTypes issueType)
        {
            string issueReportFileName;

            switch (issueType)
            {
                case IssueTypes.Errors:
                    issueReportFileName = "errors.xml";
                    break;
                case IssueTypes.Warnings:
                    issueReportFileName = "warnings.xml";
                    break;

                default: throw new IssueTypeNotSupportedException($"'{issueType}' issues type is not supported.");
            }

            var rawIssueReport = new XmlDocument();
            rawIssueReport.LoadXml(issueReportFileName);

            var issueReport = new IssueReport
            {
                DateTime = new IssueReportDateTimeParser().Parse(rawIssueReport),
                Issues = new IssueReportIssueParser().Parse(rawIssueReport, issueType)
            };

            return issueReport;
        }
    }
}
