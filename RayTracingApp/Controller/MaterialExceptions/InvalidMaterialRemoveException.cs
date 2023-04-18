using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.MaterialExceptions
{
    public class InvalidMaterialRemoveException : Exception
    {
        public InvalidMaterialRemoveException(string message) : base(message) { }
    }
}
