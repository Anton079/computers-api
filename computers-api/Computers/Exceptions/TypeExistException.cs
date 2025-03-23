using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class TypeExistException:Exception
    {
        public TypeExistException() :base(ExceptionMessages.TypeExistException) { }
    }
}
