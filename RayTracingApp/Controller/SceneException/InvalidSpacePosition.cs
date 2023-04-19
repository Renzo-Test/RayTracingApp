namespace Controller.SceneExceptions
{
    public class InvalidSpacePosition : InvalidSceneInputException
    {
        public InvalidSpacePosition(string message) : base(message) { }
    }
}
