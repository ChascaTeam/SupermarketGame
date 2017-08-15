using System;

namespace Supermarket.Management.Exceptions
{
    public class InvalidSizeException : Exception
    {
        public const string InvalidSize = "Not enough space in the Warehouse!";

        public InvalidSizeException()
            : base(InvalidSize)
        {
        }

        public InvalidSizeException(string message)
            : base(message)
        {
        }
    }
}
