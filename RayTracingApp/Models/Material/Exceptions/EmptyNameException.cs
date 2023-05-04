
namespace Models.MaterialExceptions
{
    public class EmptyNameException : InvalidMaterialInputException
    {
        public EmptyNameException(string message) : base(message) { }
    }
}
