using System;

namespace Controller.Exceptions
{
	public class InvalidFigureRemoveException : Exception
	{
		public InvalidFigureRemoveException(string message) : base(message) { }
	}
}
