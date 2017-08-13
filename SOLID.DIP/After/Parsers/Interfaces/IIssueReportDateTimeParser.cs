using System;
using System.Xml;

namespace SOLID.DIP.After.Parsers.Interfaces
{
    public interface IIssueReportDateTimeParser
    {
        DateTime Parse(XmlDocument rawIssueReport);
    }
}