using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Providers
{
    public interface IIssueInfoAndInstanceProvider
    {
        string ReportFileName { get; }

        string Tag { get; }

        IIssue ProvideInstance(string message);
    }
}
