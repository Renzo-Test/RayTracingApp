
using Models.ClientExceptions;

namespace Controller.ClientExceptions
{
	public class AlreadyExistingClientException : InvalidCredentialsException
	{
		public AlreadyExistingClientException(string message) : base(message) { }
	}
}
