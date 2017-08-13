using SOLID.LSP.Before.Models;

namespace SOLID.LSP.Before.Providers
{
    public class WarningIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "warnings.xml";

        public string Tag => "Warning";

        public IIssue ProvideInstance(string message) => new Warning { Message = message };
    }
}
