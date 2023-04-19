namespace Controller.SceneExceptions
{
    public class InvalidSpacePositionException : InvalidSceneInputException
    {
        public InvalidSpacePositionException(string message) : base(message) { }
    }
}
