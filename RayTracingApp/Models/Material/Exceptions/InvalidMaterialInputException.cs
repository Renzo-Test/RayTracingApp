using System;

namespace Models.MaterialExceptions
{
    public class InvalidMaterialInputException : Exception
    {
        public InvalidMaterialInputException(string message) : base(message) { }
    }
}
