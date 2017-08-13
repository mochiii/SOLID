using System.Collections.Generic;
using System.Xml;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Providers;

namespace SOLID.DIP.After.Parsers.Interfaces
{
    public interface IIssueReportIssueParser
    {
        List<IIssue> Parse(XmlDocument rawIssueReport, IIssueInfoAndInstanceProvider issueInfoAndInstanceProvider);
    }
}