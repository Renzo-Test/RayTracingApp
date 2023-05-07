namespace Models.SceneExceptions
{
	public class InvalidFovException : InvalidSceneInputException
	{
		public InvalidFovException(string message) : base(message) { }
	}
}
