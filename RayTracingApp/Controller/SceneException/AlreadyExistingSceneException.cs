using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class AlreadyExistingSceneException : InvalidSceneInputException
	{
		public AlreadyExistingSceneException(string message) : base(message) { }
	}
}
