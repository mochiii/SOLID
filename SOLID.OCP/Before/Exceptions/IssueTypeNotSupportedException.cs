using System;

namespace SOLID.OCP.Before.Exceptions
{
    public class IssueTypeNotSupportedException : Exception
    {
        public IssueTypeNotSupportedException(string message) : base(message)
        {
        }
    }
}
