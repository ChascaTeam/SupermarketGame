using System;

namespace Supermarket.Management.Exceptions
{
   public class InvalidInputException : Exception
    {
        public const string InvalidInput = "Wrong input! Only numbers are accepted!";

        public InvalidInputException()
            : base(InvalidInput)
        {
        }

        public InvalidInputException(string message)
            : base(message)
        {
        }
    }
}

