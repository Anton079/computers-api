using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class IdExistException : Exception
    {
        public IdExistException() : base(ExceptionMessages.IdExistException)
        {

        }
    }
}
