using System;

namespace Supermarket.Management.Exceptions
{
   public class WrongOrderException : Exception
    {
        public const string Overflow = "Your order is above the market limits!";

        public WrongOrderException()
            : base(Overflow)
        {
        }

        public WrongOrderException(string message)
            : base(message)
        {
        }
    }
}
