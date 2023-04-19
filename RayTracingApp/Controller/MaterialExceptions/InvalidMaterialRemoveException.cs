using System;

namespace Controller.MaterialExceptions
{
    public class InvalidMaterialRemoveException : Exception
    {
        public InvalidMaterialRemoveException(string message) : base(message) { }
    }
}
