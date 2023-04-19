
namespace Controller.FigureExceptions
{
    public class NotInExpectedRangeException : InvalidFigureInputException
    {
        public NotInExpectedRangeException(string message) : base(message) { }
    }
}
