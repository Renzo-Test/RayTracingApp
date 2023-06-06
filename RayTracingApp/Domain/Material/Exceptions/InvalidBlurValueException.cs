using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidBlurValueException : InvalidMaterialInputException
    {
        public InvalidBlurValueException(string message) : base(message) { }
    }
}
