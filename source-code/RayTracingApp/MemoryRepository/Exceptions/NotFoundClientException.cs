using System;


namespace MemoryRepository.Exceptions
{
	public class NotFoundClientException : Exception
	{
		public NotFoundClientException(string message) : base(message) { }
	}
}
