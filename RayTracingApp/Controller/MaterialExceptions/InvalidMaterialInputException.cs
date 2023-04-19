using System;

namespace Controller.MaterialExceptions
{
    public class InvalidMaterialInputException : Exception
    {
        public InvalidMaterialInputException(string message) : base(message) { }
    }
}
