namespace Controller.Exceptions
{
	public class FigureUsedByModelException : InvalidFigureRemoveException
	{
		public FigureUsedByModelException(string message) : base(message) { }
	}
}
