using System;

namespace Controller.FigureExceptions
{
    public class InvalidFigureInputException : Exception
    {
        public InvalidFigureInputException(string message) : base(message) { }
    }
}
