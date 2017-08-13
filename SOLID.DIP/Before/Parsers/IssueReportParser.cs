using System.Xml;
using SOLID.DIP.Before.Exceptions;
using SOLID.DIP.Before.Models;
using SOLID.DIP.Before.Retrievers;

namespace SOLID.DIP.Before.Parsers
{
    public class IssueReportParser : IIssueReportParser, IPermissiveIssueReportParser
    {
        private readonly IssueInfoAndInstanceProviderRetriever _issueInfoAndInstanceProviderRetriever;

        public IssueReportParser()
        {
            _issueInfoAndInstanceProviderRetriever = new IssueInfoAndInstanceProviderRetriever();
        }

        public virtual IssueReport Parse(IssueTypes issueType)
        {
            var issueInfoAndInstanceProvider = _issueInfoAndInstanceProviderRetriever.Retrieve(issueType);

            var rawIssueReport = new XmlDocument();
            rawIssueReport.LoadXml(issueInfoAndInstanceProvider.ReportFileName);

            var issueReport = new IssueReport
            {
                DateTime = new IssueReportDateTimeParser().Parse(rawIssueReport),
                Issues = new IssueReportIssueParser().Parse(rawIssueReport, issueInfoAndInstanceProvider)
            };

            return issueReport;
        }

        public IssueReport TryParse(IssueTypes issueType)
        {
            var issueReport = default(IssueReport);

            try
            {
                issueReport = Parse(issueType);
            }
            catch (IssueTypeNotSupportedException)
            {
            }
            catch (ElementNotFoundException)
            {
            }
            catch (ElementIsEmptyException)
            {
            }

            return issueReport;
        }
    }
}
