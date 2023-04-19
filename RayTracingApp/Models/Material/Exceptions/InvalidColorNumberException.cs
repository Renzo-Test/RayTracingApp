using System;

namespace Models.Exceptions
{
    public class InvalidColorNumberException : Exception
    {
        public InvalidColorNumberException(string message) : base(message) { }
    }
}
