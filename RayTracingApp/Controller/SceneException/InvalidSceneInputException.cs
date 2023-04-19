using System;

namespace Controller.SceneExceptions
{
    public class InvalidSceneInputException : Exception
    {
        public InvalidSceneInputException(string message) : base(message) { }
    }
}
