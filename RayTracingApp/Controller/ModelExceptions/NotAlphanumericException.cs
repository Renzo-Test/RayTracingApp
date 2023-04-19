namespace Controller.ModelExceptions
{
    public class NotAlphanumericException : InvalidModelInputException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
