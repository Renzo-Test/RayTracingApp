using System;

namespace Domain.Exceptions
{
	public class InvalidColorNumberException : Exception
	{
		public InvalidColorNumberException(string message) : base(message) { }
	}
}
