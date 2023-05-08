
namespace Domain.Exceptions
{
	public class SmallerThanCeroRadiusException : InvalidFigureInputException
	{
		public SmallerThanCeroRadiusException(string message) : base(message) { }
	}
}
