using System;

namespace SOLID.DIP.Before.Exceptions
{
    public class ElementIsEmptyException : Exception
    {
        public ElementIsEmptyException(string message) : base(message)
        {
        }
    }
}
