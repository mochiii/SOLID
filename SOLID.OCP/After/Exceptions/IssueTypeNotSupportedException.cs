using System;

namespace SOLID.OCP.After.Exceptions
{
    public class IssueTypeNotSupportedException : Exception
    {
        public IssueTypeNotSupportedException(string message) : base(message)
        {
        }
    }
}
