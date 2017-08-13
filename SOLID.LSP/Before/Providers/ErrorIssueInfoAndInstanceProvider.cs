using SOLID.LSP.Before.Models;

namespace SOLID.LSP.Before.Providers
{
    public class ErrorIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "errors.xml";

        public string Tag => "Error";

        public IIssue ProvideInstance(string message) => new Error { Message = message };
    }
}
