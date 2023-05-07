
namespace Models.ClientExceptions
{
	public class NotInExpectedRangeException : InvalidCredentialsException
	{
		public NotInExpectedRangeException(string message) : base(message) { }
	}
}
