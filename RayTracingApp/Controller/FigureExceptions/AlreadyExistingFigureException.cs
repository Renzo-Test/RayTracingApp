using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.FigureExceptions
{
    public class AlreadyExistingFigureException : InvalidFigureInputException
    {
        public AlreadyExistingFigureException(string message) : base(message) { }
    }
}
