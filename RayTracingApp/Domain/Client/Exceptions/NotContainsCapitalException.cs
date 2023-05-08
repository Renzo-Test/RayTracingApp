
namespace Domain.Exceptions
{
	public class NotContainsCapitalException : InvalidCredentialsException
	{
		public NotContainsCapitalException(string message) : base(message) { }
	}
}
