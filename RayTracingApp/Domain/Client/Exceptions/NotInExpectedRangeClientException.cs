
namespace Domain.Exceptions
{
	public class NotInExpectedRangeClientException : InvalidCredentialsException
	{
		public NotInExpectedRangeClientException(string message) : base(message) { }
	}
}
