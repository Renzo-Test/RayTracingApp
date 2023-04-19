using System;

namespace Controller.ModelExceptions
{
    public class InvalidModelInputException : Exception
    {
        public InvalidModelInputException(string message) : base(message) { }
    }
}
