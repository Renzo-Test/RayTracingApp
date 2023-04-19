
namespace Controller.ClientExceptions
{
    public class NotAlphanumericException : InvalidCredentialsException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
