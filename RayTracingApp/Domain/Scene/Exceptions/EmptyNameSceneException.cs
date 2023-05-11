namespace Domain.Exceptions
{
	public class EmptyNameSceneException : InvalidSceneInputException
	{
		public EmptyNameSceneException(string message) : base(message) { }
	}
}
