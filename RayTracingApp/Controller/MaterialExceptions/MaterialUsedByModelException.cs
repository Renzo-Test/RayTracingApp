using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.MaterialExceptions
{
    public class MaterialUsedByModelException : InvalidMaterialInputException
    {
        public MaterialUsedByModelException(string message) : base(message) { }
    }
}
