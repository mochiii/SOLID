using System;

namespace SOLID.LSP.After.Exceptions
{
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(string message) : base(message)
        {
        }
    }
}
