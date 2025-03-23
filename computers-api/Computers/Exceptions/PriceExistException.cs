using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class PriceExistException:Exception
    {
        public PriceExistException() :base(ExceptionMessages.PriceExistException) { }
    }
}
