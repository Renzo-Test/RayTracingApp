namespace Domain.Exceptions
{
	public class InvalidBlurValueException : InvalidMaterialInputException
	{
		public InvalidBlurValueException(string message) : base(message) { }
	}
}
