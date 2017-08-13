using System;

namespace SOLID.ISP.After.Exceptions
{
    public class IssueTypeNotImportantException : Exception
    {
        public IssueTypeNotImportantException(string message) : base(message)
        {
        }
    }
}
