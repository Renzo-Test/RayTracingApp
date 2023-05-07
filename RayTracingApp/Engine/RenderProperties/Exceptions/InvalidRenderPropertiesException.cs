using System;

namespace Engine.RenderProperties.Exceptions
{
	public class InvalidRenderPropertiesInputException : Exception
	{
		public InvalidRenderPropertiesInputException(string message) : base(message) { }
	}
}
