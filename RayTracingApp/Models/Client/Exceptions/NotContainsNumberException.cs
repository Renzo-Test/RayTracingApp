
namespace Domain.Exceptions
{
	public class NotContainsNumberException : InvalidCredentialsException
	{
		public NotContainsNumberException(string message) : base(message) { }
	}
}
