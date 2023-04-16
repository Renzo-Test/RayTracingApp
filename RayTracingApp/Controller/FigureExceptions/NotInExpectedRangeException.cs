using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.FigureExceptions
{
    public class NotInExpectedRangeException : InvalidFigureInputException
    {
        public NotInExpectedRangeException(string message) : base(message) { }
    }
}
