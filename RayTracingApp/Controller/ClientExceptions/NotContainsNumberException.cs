
namespace Controller.ClientExceptions
{
    public class NotContainsNumberException : InvalidCredentialsException
    {
        public NotContainsNumberException(string message) : base(message) { }
    }
}
