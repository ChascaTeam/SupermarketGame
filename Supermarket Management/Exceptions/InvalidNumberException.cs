using System;

namespace Supermarket.Management.Exceptions
{
    public class InvalidNumberException : Exception
    {
        public const string InvalidNumber = "Number cannot be negative!";

        public InvalidNumberException()
            : base(InvalidNumber)
        {
        }

        public InvalidNumberException(string message)
            : base(message)
        {
        }
    }
}

