using SOLID.ISP.After.Models;

namespace SOLID.ISP.After.Providers
{
    public interface IIssueInfoAndInstanceProvider
    {
        string ReportFileName { get; }

        string Tag { get; }

        IIssue ProvideInstance(string message);
    }
}
