using System.Collections.Generic;
using System.Xml;
using SOLID.SRP.After.Exceptions;

namespace SOLID.SRP.After.Parsers
{
    public class IssueReportIssueParser
    {
        private const string ErrorTag = "Error";

        public List<string> Parse(XmlDocument rawIssueReport)
        {
            var errors = new List<string>();

            var rawErrors = rawIssueReport.GetElementsByTagName(ErrorTag);
            for (var errorIndex = 0; errorIndex < rawErrors.Count; errorIndex++)
            {
                var error = rawErrors[errorIndex].InnerText;
                if (string.IsNullOrWhiteSpace(error))
                {
                    throw new ElementIsEmptyException($"{ErrorTag} element is empty in source xml report.");
                }

                errors.Add(error);
            }

            return errors;
        }
    }
}
