using System;

namespace SOLID.DIP.After.Exceptions
{
    public class IssueTypeNotImportantException : Exception
    {
        public IssueTypeNotImportantException(string message) : base(message)
        {
        }
    }
}
