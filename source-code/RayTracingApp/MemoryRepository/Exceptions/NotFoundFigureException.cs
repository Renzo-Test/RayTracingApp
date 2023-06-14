using System;

namespace MemoryRepository.Exceptions
{
	public class NotFoundFigureException : Exception
	{
		public NotFoundFigureException(string message) : base(message) { }
	}
}
