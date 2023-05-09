using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class AlreadyExistingClientException : InvalidCredentialsException
	{
		public AlreadyExistingClientException(string message) : base(message) { }
	}
}
