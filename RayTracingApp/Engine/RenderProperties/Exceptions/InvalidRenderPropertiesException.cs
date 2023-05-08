using System;

namespace Engine.Exceptions
{
	public class InvalidRenderPropertiesInputException : Exception
	{
		public InvalidRenderPropertiesInputException(string message) : base(message) { }
	}
}
