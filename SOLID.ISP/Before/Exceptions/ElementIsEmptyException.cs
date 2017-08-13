using System;

namespace SOLID.ISP.Before.Exceptions
{
    public class ElementIsEmptyException : Exception
    {
        public ElementIsEmptyException(string message) : base(message)
        {
        }
    }
}
