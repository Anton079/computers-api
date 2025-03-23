using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class NullComputerException : Exception
    {
        public NullComputerException() : base(ExceptionMessages.NullComputerException)
        {

        }
    }
}
