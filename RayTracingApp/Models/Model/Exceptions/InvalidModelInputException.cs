using System;

namespace Models.ModelExceptions
{
	public class InvalidModelInputException : Exception
	{
		public InvalidModelInputException(string message) : base(message) { }
	}
}
