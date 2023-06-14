using System;


namespace DBRepository.Exceptions
{
	public class NotFoundClientException : Exception
	{
		public NotFoundClientException(string message) : base(message) { }
	}
}
