using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class AlreadyExistingFigureException : InvalidFigureInputException
	{
		public AlreadyExistingFigureException(string message) : base(message) { }
	}
}
