using Controller.SphereExceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class SphereController : FigureController
    {
        private const string SmallerThanCeroRadiusMessage = "Sphere's radius must be greater than cero";

        public override void RunFigurePropertiesChecker(Figure figure)
        {
            Sphere sphere = (Sphere)figure;

            if (!RadiusGreaterThanZero(sphere))
            {
                throw new SmallerThanCeroRadiusException(SmallerThanCeroRadiusMessage);
            }
        }

        private bool RadiusGreaterThanZero(Sphere sphere)
        {
            return sphere.Radius > 0;
        }
    }
}
