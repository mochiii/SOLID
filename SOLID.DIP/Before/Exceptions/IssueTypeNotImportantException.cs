using System;

namespace SOLID.DIP.Before.Exceptions
{
    public class IssueTypeNotImportantException : Exception
    {
        public IssueTypeNotImportantException(string message) : base(message)
        {
        }
    }
}
