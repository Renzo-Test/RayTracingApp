using Controller.FigureExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.SphereExceptions
{
    public class SmallerThanCeroRadiusException : InvalidFigureInputException
    {
        public SmallerThanCeroRadiusException(string message) : base(message) { }
    }
}
