using Domain.Exceptions;

namespace Controller.Exceptions
{
	public class MaterialUsedByModelException : InvalidMaterialRemoveException
	{
		public MaterialUsedByModelException(string message) : base(message) { }
	}
}
