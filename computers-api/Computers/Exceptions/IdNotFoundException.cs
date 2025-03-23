using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException() :base(ExceptionMessages.IdNotFoundException) { }
    }
}
