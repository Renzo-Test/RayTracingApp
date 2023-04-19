namespace Controller.ModelExceptions
{
    public class EmptyNameException : InvalidModelInputException
    {
        public EmptyNameException(string message) : base(message) { }
    }
}
