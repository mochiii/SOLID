using System;

namespace SOLID.OCP.Before.Exceptions
{
    public class ElementIsEmptyException : Exception
    {
        public ElementIsEmptyException(string message) : base(message)
        {
        }
    }
}
