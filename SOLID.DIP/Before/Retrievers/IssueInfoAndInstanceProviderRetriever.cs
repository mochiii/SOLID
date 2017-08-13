using SOLID.DIP.Before.Exceptions;
using SOLID.DIP.Before.Models;
using SOLID.DIP.Before.Providers;

namespace SOLID.DIP.Before.Retrievers
{
    public class IssueInfoAndInstanceProviderRetriever
    {
        private readonly IIssueInfoAndInstanceProvider[] _issueInfoAndInstanceProviders;

        public IssueInfoAndInstanceProviderRetriever()
        {
            _issueInfoAndInstanceProviders = new ConfigurationRietriever().RetrieveIssueInfoAndInstanceProviders();
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
