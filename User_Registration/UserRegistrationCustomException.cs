using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        private readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
