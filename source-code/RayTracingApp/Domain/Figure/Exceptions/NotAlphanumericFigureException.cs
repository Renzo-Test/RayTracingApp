
namespace Domain.Exceptions
{
	public class NotAlphanumericFigureException : InvalidFigureInputException
	{
		public NotAlphanumericFigureException(string message) : base(message) { }
	}
}
