using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Providers
{
    public class ErrorIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "errors.xml";

        public string Tag => "Error";

        public IIssue ProvideInstance(string message) => new Error { Message = message };
    }
}
