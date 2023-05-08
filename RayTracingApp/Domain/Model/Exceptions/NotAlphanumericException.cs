namespace Domain.Exceptions
{
	public class NotAlphanumericException : InvalidModelInputException
	{
		public NotAlphanumericException(string message) : base(message) { }
	}
}
