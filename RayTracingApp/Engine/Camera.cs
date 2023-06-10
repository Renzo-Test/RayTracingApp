using Domain;
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
        private double LensRadius { get; set; }

        public Camera(Vector vectorLookFrom, Vector vectorLookAt, Vector vectorUp, int fieldOfView, double aspectRatio, double aperture, double focalDistance)
        {
            LensRadius = aperture / 2;
            double Theta = fieldOfView * Math.PI / 180;
            double HeightHalf = Math.Tan(Theta / 2);
            double WidthHalf = aspectRatio * HeightHalf;
            
            Origin = vectorLookFrom;

            Vector VectorW = vectorLookFrom.Substract(vectorLookAt).GetUnit();
            Vector VectorU = vectorUp.Cross(VectorW).GetUnit();
            Vector VectorV = VectorW.Cross(VectorU);
            
            VectorLowerLeftCorner = Origin.Substract(VectorU.Multiply(WidthHalf)).Substract(VectorV.Multiply(HeightHalf)).Substract(VectorW);
            VectorHorizontal = VectorU.Multiply(2 * WidthHalf);
            VectorVertical = VectorV.Multiply(2 * HeightHalf);
        }
        public Ray GetRay(double u, double v)
        {
            Vector horizontalPosition = VectorHorizontal.Multiply(u);
            Vector verticalPosition = VectorVertical.Multiply(v);

            Vector pointPosition = VectorLowerLeftCorner.Add(horizontalPosition.Add(verticalPosition));

            return new Ray()
            {
                Origin = Origin,
                Direction = pointPosition.Substract(this.Origin)
            };
        }
    }
}
