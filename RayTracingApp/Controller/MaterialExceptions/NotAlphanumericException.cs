using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.MaterialExceptions
{
    public class NotAlphanumericException : InvalidMaterialInputException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
