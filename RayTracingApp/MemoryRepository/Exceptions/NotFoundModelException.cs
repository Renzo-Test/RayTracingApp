using System;

namespace MemoryRepository.Exceptions
{
	public class NotFoundModelException : Exception
	{
		public NotFoundModelException(string message) : base(message) { }
	}
}
