namespace Models.ModelExceptions
{
	public class NotAlphanumericException : InvalidModelInputException
	{
		public NotAlphanumericException(string message) : base(message) { }
	}
}
