using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class SphereController : FigureController
    {
        public override bool FigureIsValid(Figure figure)
        {
            return true;
        }
    }
}
