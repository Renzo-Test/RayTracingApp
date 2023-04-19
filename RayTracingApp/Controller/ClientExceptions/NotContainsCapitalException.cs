
namespace Controller.ClientExceptions
{
    public class NotContainsCapitalException : InvalidCredentialsException
    {
        public NotContainsCapitalException(string message) : base(message) { }
    }
}
