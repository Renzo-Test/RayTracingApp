using System;

namespace Domain.Exceptions
{
	public class InvalidSceneInputException : Exception
	{
		public InvalidSceneInputException(string message) : base(message) { }
	}
}
