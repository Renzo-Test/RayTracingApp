using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Ray
    {
        public Vector Origin { get; set; }
        public Vector Direction { get; set; }

        public Vector PointAt(double multiplier)
        {
            return new Vector() { X = 5, Y = 7, Z = 2 };
        }
    }
}
