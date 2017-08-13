using SOLID.DIP.After.Models;
using SOLID.DIP.After.Providers;

namespace SOLID.DIP.After.Retrievers.Interfaces
{
    public interface IIssueInfoAndInstanceProviderRetriever
    {
        IIssueInfoAndInstanceProvider Retrieve(IssueTypes issueType);
    }
}