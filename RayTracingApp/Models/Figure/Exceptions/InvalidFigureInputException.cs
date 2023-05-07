using System;

namespace Models.FigureExceptions
{
	public class InvalidFigureInputException : Exception
	{
		public InvalidFigureInputException(string message) : base(message) { }
	}
}
