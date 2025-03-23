using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class NullTypeException : Exception
    {
        public NullTypeException() : base(ExceptionMessages.NullTypeException)
        {

        }
    }
}
