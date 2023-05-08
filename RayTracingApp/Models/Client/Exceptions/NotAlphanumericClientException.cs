
namespace Domain.Exceptions
{
	public class NotAlphanumericClientException : InvalidCredentialsException
	{
		public NotAlphanumericClientException(string message) : base(message) { }
	}
}
