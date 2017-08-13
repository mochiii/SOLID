using System;

namespace SOLID.LSP.Before.Exceptions
{
    public class IssueTypeNotImportantException : Exception
    {
        public IssueTypeNotImportantException(string message) : base(message)
        {
        }
    }
}
