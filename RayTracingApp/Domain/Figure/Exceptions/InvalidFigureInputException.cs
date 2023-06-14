using System;

namespace Domain.Exceptions
{
	public class InvalidFigureInputException : Exception
	{
		public InvalidFigureInputException(string message) : base(message) { }
	}
}
