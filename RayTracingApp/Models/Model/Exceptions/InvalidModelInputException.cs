using System;

namespace Domain.Exceptions
{
	public class InvalidModelInputException : Exception
	{
		public InvalidModelInputException(string message) : base(message) { }
	}
}
