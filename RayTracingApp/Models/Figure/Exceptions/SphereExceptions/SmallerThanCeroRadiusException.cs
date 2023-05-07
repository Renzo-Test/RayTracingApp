using Models.FigureExceptions;

namespace Models.SphereExceptions
{
	public class SmallerThanCeroRadiusException : InvalidFigureInputException
	{
		public SmallerThanCeroRadiusException(string message) : base(message) { }
	}
}
