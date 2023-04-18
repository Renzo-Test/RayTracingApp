using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ModelExceptions
{
    public class NotAlphanumericException : InvalidModelInputException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
