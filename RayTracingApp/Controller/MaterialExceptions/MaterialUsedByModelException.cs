using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class MaterialUsedByModelException : InvalidMaterialInputException
	{
		public MaterialUsedByModelException(string message) : base(message) { }
	}
}
