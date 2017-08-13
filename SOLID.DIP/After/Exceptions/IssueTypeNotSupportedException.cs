using System;

namespace SOLID.DIP.After.Exceptions
{
    public class IssueTypeNotSupportedException : Exception
    {
        public IssueTypeNotSupportedException(string message) : base(message)
        {
        }
    }
}
