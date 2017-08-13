using SOLID.LSP.After.Models;

namespace SOLID.LSP.After.Providers
{
    public class ErrorIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "errors.xml";

        public string Tag => "Error";

        public IIssue ProvideInstance(string message) => new Error { Message = message };
    }
}
