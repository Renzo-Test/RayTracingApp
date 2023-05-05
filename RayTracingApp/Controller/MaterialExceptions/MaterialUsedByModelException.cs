using Models.MaterialExceptions;

namespace Controller.MaterialExceptions
{
    public class MaterialUsedByModelException : InvalidMaterialInputException
    {
        public MaterialUsedByModelException(string message) : base(message) { }
    }
}
