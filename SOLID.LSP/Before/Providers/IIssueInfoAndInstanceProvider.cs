using SOLID.LSP.Before.Models;

namespace SOLID.LSP.Before.Providers
{
    public interface IIssueInfoAndInstanceProvider
    {
        string ReportFileName { get; }

        string Tag { get; }

        IIssue ProvideInstance(string message);
    }
}
