namespace Domain.Exceptions
{
	public class EmptyNameModelException : InvalidModelInputException
	{
		public EmptyNameModelException(string message) : base(message) { }
	}
}
