using System;

namespace DBRepository.Exceptions
{
	public class NotFoundModelException : Exception
	{
		public NotFoundModelException(string message) : base(message) { }
	}
}
