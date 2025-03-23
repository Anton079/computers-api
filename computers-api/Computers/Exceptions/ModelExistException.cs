using computers_api.System;

namespace computers_api.Computers.Exceptions
{
    public class ModelExistException:Exception
    {
        public ModelExistException() :base(ExceptionMessages.ModelExistException) { }
    }
}
