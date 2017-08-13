using System;

namespace SOLID.ISP.Before.Exceptions
{
    public class IssueTypeNotSupportedException : Exception
    {
        public IssueTypeNotSupportedException(string message) : base(message)
        {
        }
    }
}
