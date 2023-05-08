namespace Domain.Exceptions
{
	public class InvalidSpacePositionException : InvalidSceneInputException
	{
		public InvalidSpacePositionException(string message) : base(message) { }
	}
}
