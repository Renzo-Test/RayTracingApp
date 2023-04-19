namespace Controller.MaterialExceptions
{
    public class NotAlphanumericException : InvalidMaterialInputException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
