using System;

namespace Controller.FigureExceptions
{
	public class InvalidFigureRemoveException : Exception
	{
		public InvalidFigureRemoveException(string message) : base(message) { }
	}
}
