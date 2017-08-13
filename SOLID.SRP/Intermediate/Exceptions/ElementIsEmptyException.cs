using System;

namespace SOLID.SRP.Intermediate.Exceptions
{
    public class ElementIsEmptyException : Exception
    {
        public ElementIsEmptyException(string message) : base(message)
        {
        }
    }
}
