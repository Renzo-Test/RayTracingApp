using System;

namespace Models.SceneExceptions
{
    public class InvalidSceneInputException : Exception
    {
        public InvalidSceneInputException(string message) : base(message) { }
    }
}
