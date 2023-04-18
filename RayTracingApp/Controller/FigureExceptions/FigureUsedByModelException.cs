using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.FigureExceptions
{
    public class FigureUsedByModelException : InvalidFigureRemoveException
    {
        public FigureUsedByModelException(string message) : base(message) { }
    }
}
