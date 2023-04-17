using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.MaterialExceptions
{
    public class EmptyNameException : InvalidMaterialInputException
    {
        public EmptyNameException(string message) : base(message) { }
    }
}
