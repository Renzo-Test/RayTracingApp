
namespace Domain.Exceptions
{
	public class NotInExpectedRangeFigureException : InvalidFigureInputException
	{
		public NotInExpectedRangeFigureException(string message) : base(message) { }
	}
}
