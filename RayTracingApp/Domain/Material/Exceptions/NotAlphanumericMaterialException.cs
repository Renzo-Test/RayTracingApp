namespace Domain.Exceptions
{
	public class NotAlphanumericMaterialException : InvalidMaterialInputException
	{
		public NotAlphanumericMaterialException(string message) : base(message) { }
	}
}
