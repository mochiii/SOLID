using SOLID.DIP.After.Exceptions;
using SOLID.DIP.After.Factories;
using SOLID.DIP.After.Factories.Interfaces;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Parsers.Interfaces;
using SOLID.DIP.After.Retrievers;
using SOLID.DIP.After.Retrievers.Interfaces;

namespace SOLID.DIP.After.Parsers
{
    public class IssueReportParser : IIssueReportParser, IPermissiveIssueReportParser
    {
        private readonly IIssueInfoAndInstanceProviderRetriever _issueInfoAndInstanceProviderRetriever;
        private readonly IIssueReportDateTimeParser _issueReportDateTimeParser;
        private readonly IIssueReportIssueParser _issueReportIssueParser;
        private readonly IXmlDocumentFactory _xmlDocumentFactory;

        public IssueReportParser()
        {
            _issueInfoAndInstanceProviderRetriever = new IssueInfoAndInstanceProviderRetriever();
            _issueReportDateTimeParser = new IssueReportDateTimeParser();
            _issueReportIssueParser = new IssueReportIssueParser();
            _xmlDocumentFactory = new XmlDocumentFactory();
        }

        public IssueReportParser(
            IIssueInfoAndInstanceProviderRetriever issueInfoAndInstanceProviderRetriever,
            IIssueReportDateTimeParser issueReportDateTimeParser,
            IIssueReportIssueParser issueReportIssueParser,
            IXmlDocumentFactory xmlDocumentFactory)
        {
            _issueInfoAndInstanceProviderRetriever = issueInfoAndInstanceProviderRetriever;
            _issueReportDateTimeParser = issueReportDateTimeParser;
            _issueReportIssueParser = issueReportIssueParser;
            _xmlDocumentFactory = xmlDocumentFactory;
        }

        public virtual IssueReport Parse(IssueTypes issueType)
        {
            var issueInfoAndInstanceProvider = _issueInfoAndInstanceProviderRetriever.Retrieve(issueType);

            var rawIssueReport = _xmlDocumentFactory.Create(issueInfoAndInstanceProvider.ReportFileName);

            var issueReport = new IssueReport
            {
                DateTime = _issueReportDateTimeParser.Parse(rawIssueReport),
                Issues = _issueReportIssueParser.Parse(rawIssueReport, issueInfoAndInstanceProvider)
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
