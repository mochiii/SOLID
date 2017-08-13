using SOLID.DIP.After.Exceptions;
using SOLID.DIP.After.Models;
using SOLID.DIP.After.Providers;
using SOLID.DIP.After.Retrievers.Interfaces;

namespace SOLID.DIP.After.Retrievers
{
    public class IssueInfoAndInstanceProviderRetriever : IIssueInfoAndInstanceProviderRetriever
    {
        private readonly IIssueInfoAndInstanceProvider[] _issueInfoAndInstanceProviders;

        public IssueInfoAndInstanceProviderRetriever()
        {
            _issueInfoAndInstanceProviders = new ConfigurationRietriever().RetrieveIssueInfoAndInstanceProviders();
        }

        public IssueInfoAndInstanceProviderRetriever(IConfigurationRietriever configurationRietriever)
        {
            _issueInfoAndInstanceProviders = configurationRietriever.RetrieveIssueInfoAndInstanceProviders();
        }

        public IIssueInfoAndInstanceProvider Retrieve(IssueTypes issueType)
        {
            var issueTypeIndex = (int) issueType;
            if (issueTypeIndex >= _issueInfoAndInstanceProviders.Length)
            {
                throw new IssueTypeNotSupportedException($"'{issueType}' issues type is not supported.");
            }

            return _issueInfoAndInstanceProviders[issueTypeIndex];
        }
    }
}
