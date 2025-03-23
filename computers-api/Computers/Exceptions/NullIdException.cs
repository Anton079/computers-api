using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class NullIdException : Exception
    {
        public NullIdException() : base(ExceptionMessages.NullIdException)
        {

        }
    }
}
