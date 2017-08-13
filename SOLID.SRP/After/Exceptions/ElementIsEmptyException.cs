using System;

namespace SOLID.SRP.After.Exceptions
{
    public class ElementIsEmptyException : Exception
    {
        public ElementIsEmptyException(string message) : base(message)
        {
        }
    }
}
