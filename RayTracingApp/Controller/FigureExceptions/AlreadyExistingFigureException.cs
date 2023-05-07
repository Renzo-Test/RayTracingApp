using Models.FigureExceptions;

namespace Controller.FigureExceptions
{
	public class AlreadyExistingFigureException : InvalidFigureInputException
	{
		public AlreadyExistingFigureException(string message) : base(message) { }
	}
}
