using Models.ClientExceptions;

namespace Controller.ClientExceptions
{
    public class NotCorrectPasswordException : InvalidCredentialsException
    {
        public NotCorrectPasswordException(string message) : base(message) { }
    }
}
