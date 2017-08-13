using SOLID.ISP.Before.Models;

namespace SOLID.ISP.Before.Providers
{
    public class ErrorIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "errors.xml";

        public string Tag => "Error";

        public IIssue ProvideInstance(string message) => new Error { Message = message };
    }
}
