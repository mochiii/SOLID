using SOLID.DIP.Before.Models;

namespace SOLID.DIP.Before.Providers
{
    public interface IIssueInfoAndInstanceProvider
    {
        string ReportFileName { get; }

        string Tag { get; }

        IIssue ProvideInstance(string message);
    }
}
