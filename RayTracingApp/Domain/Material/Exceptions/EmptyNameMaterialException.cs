
namespace Domain.Exceptions
{
	public class EmptyNameMaterialException : InvalidMaterialInputException
	{
		public EmptyNameMaterialException(string message) : base(message) { }
	}
}
