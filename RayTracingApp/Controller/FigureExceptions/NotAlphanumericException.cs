using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.FigureExceptions
{
    public class NotAlphanumericException : InvalidFigureInputException
    {
        public NotAlphanumericException(string message) : base(message) { }
    }
}
