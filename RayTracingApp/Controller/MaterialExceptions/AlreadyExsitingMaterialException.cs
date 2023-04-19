
namespace Controller.MaterialExceptions
{
    public class AlreadyExsitingMaterialException : InvalidMaterialInputException
    {
        public AlreadyExsitingMaterialException(string message) : base(message) { }
    }
}
