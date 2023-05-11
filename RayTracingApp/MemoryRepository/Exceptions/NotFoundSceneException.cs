using System;

namespace MemoryRepository.Exceptions
{
	public class NotFoundSceneException : Exception
	{
		public NotFoundSceneException(string message) : base(message) { }
	}
}
