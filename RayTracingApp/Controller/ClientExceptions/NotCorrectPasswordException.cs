using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class NotCorrectPasswordException : InvalidCredentialsException
	{
		public NotCorrectPasswordException(string message) : base(message) { }
	}
}
