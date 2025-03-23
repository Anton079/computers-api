using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class NullPriceException : Exception
    {
        public NullPriceException() : base(ExceptionMessages.NullPriceException)
        {

        }
    }
}
