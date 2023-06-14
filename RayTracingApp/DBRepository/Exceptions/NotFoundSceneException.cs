using System;

namespace DBRepository.Exceptions
{
	public class NotFoundSceneException : Exception
	{
		public NotFoundSceneException(string message) : base(message) { }
	}
}
