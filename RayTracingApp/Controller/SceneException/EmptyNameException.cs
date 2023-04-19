namespace Controller.SceneExceptions
{
    public class EmptyNameException : InvalidSceneInputException
    {
        public EmptyNameException(string message) : base(message) { }
    }
}
