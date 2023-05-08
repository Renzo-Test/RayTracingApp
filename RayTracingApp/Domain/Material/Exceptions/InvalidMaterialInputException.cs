using System;

namespace Domain.Exceptions
{
	public class InvalidMaterialInputException : Exception
	{
		public InvalidMaterialInputException(string message) : base(message) { }
	}
}
