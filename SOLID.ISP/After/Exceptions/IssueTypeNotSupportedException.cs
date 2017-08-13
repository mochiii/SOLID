using System;

namespace SOLID.ISP.After.Exceptions
{
    public class IssueTypeNotSupportedException : Exception
    {
        public IssueTypeNotSupportedException(string message) : base(message)
        {
        }
    }
}
