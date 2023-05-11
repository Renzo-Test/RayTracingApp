using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class AlreadyExsitingMaterialException : InvalidMaterialInputException
	{
		public AlreadyExsitingMaterialException(string message) : base(message) { }
	}
}
