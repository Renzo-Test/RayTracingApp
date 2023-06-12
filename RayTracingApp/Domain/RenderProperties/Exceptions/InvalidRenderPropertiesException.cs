using System;

namespace Domain.Exceptions
{
	public class InvalidRenderPropertiesInputException : Exception
	{
		public InvalidRenderPropertiesInputException(string message) : base(message) { }
	}
}
