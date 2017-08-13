using SOLID.LSP.After.Models;

namespace SOLID.LSP.After.Providers
{
    public interface IIssueInfoAndInstanceProvider
    {
        string ReportFileName { get; }

        string Tag { get; }

        IIssue ProvideInstance(string message);
    }
}
