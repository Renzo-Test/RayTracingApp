
namespace Models.FigureExceptions
{
	public class NotAlphanumericException : InvalidFigureInputException
	{
		public NotAlphanumericException(string message) : base(message) { }
	}
}
