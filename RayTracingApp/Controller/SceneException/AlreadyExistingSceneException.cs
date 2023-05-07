using Models.SceneExceptions;

namespace Controller.SceneExceptions
{
	public class AlreadyExistingSceneException : InvalidSceneInputException
	{
		public AlreadyExistingSceneException(string message) : base(message) { }
	}
}
