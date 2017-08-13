using SOLID.OCP.After.Models;

namespace SOLID.OCP.After.Providers
{
    public class ErrorIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "errors.xml";

        public string Tag => "Error";

        public IIssue ProvideInstance(string message) => new Error { Message = message };
    }
}
