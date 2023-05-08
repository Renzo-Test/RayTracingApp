namespace Domain.Exceptions
{
	public class InvalidFovException : InvalidSceneInputException
	{
		public InvalidFovException(string message) : base(message) { }
	}
}
