using SOLID.OCP.After.Models;

namespace SOLID.OCP.After.Providers
{
    public class WarningIssueInfoAndInstanceProvider : IIssueInfoAndInstanceProvider
    {
        public string ReportFileName => "warnings.xml";

        public string Tag => "Warning";

        public IIssue ProvideInstance(string message) => new Warning { Message = message };
    }
}
