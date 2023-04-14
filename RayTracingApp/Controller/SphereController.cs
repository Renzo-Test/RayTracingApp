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
        public override bool FigurePropertiesAreValid(Figure figure)
        {
            Sphere sphere = (Sphere)figure;
            return RadiusGreaterThanZero(sphere);
        }

        private bool RadiusGreaterThanZero(Sphere sphere)
        {
            return sphere.Radius > 0;
        }
    }
}
