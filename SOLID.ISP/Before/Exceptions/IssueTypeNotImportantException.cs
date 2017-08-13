using System;

namespace SOLID.ISP.Before.Exceptions
{
    public class IssueTypeNotImportantException : Exception
    {
        public IssueTypeNotImportantException(string message) : base(message)
        {
        }
    }
}
