using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ModelExceptions
{
    public class InvalidModelInputException : Exception
    {
        public InvalidModelInputException(string message) : base (message) { }
    }
}
