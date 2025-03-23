using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class NullModelException : Exception
    {
        public NullModelException() : base(ExceptionMessages.NullModelException)
        {

        }
    }
}
