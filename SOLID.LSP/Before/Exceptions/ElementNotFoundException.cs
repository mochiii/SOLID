using System;

namespace SOLID.LSP.Before.Exceptions
{
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(string message) : base(message)
        {
        }
    }
}
