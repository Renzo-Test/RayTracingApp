using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class AlreadyExistingModelException : InvalidModelInputException
	{
		public AlreadyExistingModelException(string message) : base(message) { }
	}
}
