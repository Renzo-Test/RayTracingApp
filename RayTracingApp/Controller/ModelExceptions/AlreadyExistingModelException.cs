using Models.ModelExceptions;

namespace Controller.ModelExceptions
{
	public class AlreadyExistingModelException : InvalidModelInputException
	{
		public AlreadyExistingModelException(string message) : base(message) { }
	}
}
