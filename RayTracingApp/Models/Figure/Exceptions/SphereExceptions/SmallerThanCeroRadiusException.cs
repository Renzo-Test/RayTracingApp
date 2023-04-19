using Models.FigureExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SphereExceptions
{
    public class SmallerThanCeroRadiusException : InvalidFigureInputException
    {
        public SmallerThanCeroRadiusException(string message) : base(message) { }
    }
}
