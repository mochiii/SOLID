using SOLID.ISP.Before.Exceptions;
using SOLID.ISP.Before.Models;
using SOLID.ISP.Before.Providers;

namespace SOLID.ISP.Before.Retrievers
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
