using SOLID.DIP.After.Providers;

namespace SOLID.DIP.After.Retrievers.Interfaces
{
    public interface IConfigurationRietriever
    {
        IIssueInfoAndInstanceProvider[] RetrieveIssueInfoAndInstanceProviders();
    }
}