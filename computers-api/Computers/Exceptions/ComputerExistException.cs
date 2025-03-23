using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class ComputerExistException : Exception
    {
        public ComputerExistException() : base(ExceptionMessages.ComputerExistException)
        {

        }
    }
}
