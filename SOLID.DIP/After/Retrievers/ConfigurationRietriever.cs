using System;
using SOLID.DIP.After.Providers;
using SOLID.DIP.After.Retrievers.Interfaces;

namespace SOLID.DIP.After.Retrievers
{
    public class ConfigurationRietriever : IConfigurationRietriever
    {
        public IIssueInfoAndInstanceProvider[] RetrieveIssueInfoAndInstanceProviders()
        {
            throw new NotImplementedException();
        }
    }
}
