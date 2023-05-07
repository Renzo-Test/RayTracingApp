namespace Controller.FigureExceptions
{
	public class FigureUsedByModelException : InvalidFigureRemoveException
	{
		public FigureUsedByModelException(string message) : base(message) { }
	}
}
