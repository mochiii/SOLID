﻿using System.Xml;
using SOLID.LSP.Before.Models;
using SOLID.LSP.Before.Retrievers;

namespace SOLID.LSP.Before.Parsers
{
    public class IssueReportParser
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
    }
}
