using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Camera
    {
        private Vector VectorLowerLeftCorner { get; set; }
        private Vector VectorHorizontal { get; set; }
        private Vector VectorVertical { get; set; }
        private Vector Origin { get; set; }

        public Camera(Vector vectorLookFrom, Vector vectorLookAt, Vector vectorUp, int fieldOfView, double aspectRatio)
        {

        }
    }
}
