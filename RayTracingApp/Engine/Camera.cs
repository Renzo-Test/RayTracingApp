using Domain;
using System;

namespace Engine
{
	public class Camera
	{
        private const int ConvertToDegreeConstant = 180;
        private const int ConvertToHalfConstant = 2;
        private const int ConvertToDoubleConstant = 2;

        private Vector VectorLowerLeftCorner { get; set; }
		private Vector VectorHorizontal { get; set; }
		private Vector VectorVertical { get; set; }
		private Vector Origin { get; set; }
		private Vector VectorU { get; set; }
		private Vector VectorV { get; set; }
		private double LensRadius { get; set; }

		public Camera(Vector vectorLookFrom, Vector vectorLookAt, Vector vectorUp, int fieldOfView, double aspectRatio, double aperture, double focalDistance)
		{
			LensRadius = aperture / ConvertToHalfConstant;

			double Theta = fieldOfView * Math.PI / ConvertToDegreeConstant;
			double HeightHalf = Math.Tan(Theta / ConvertToHalfConstant);
			double WidthHalf = aspectRatio * HeightHalf;

			Origin = vectorLookFrom;

			Vector VectorW = vectorLookFrom.Substract(vectorLookAt).GetUnit();
			VectorU = vectorUp.Cross(VectorW).GetUnit();
			VectorV = VectorW.Cross(VectorU);

			VectorLowerLeftCorner = Origin
				.Substract(VectorU.Multiply(WidthHalf * focalDistance))
				.Substract(VectorV.Multiply(HeightHalf * focalDistance))
				.Substract(VectorW.Multiply(focalDistance));

			VectorHorizontal = VectorU.Multiply(ConvertToDoubleConstant * WidthHalf * focalDistance);
			VectorVertical = VectorV.Multiply(ConvertToDoubleConstant * HeightHalf * focalDistance);
		}
		public Ray GetRay(double u, double v, Vector randomVector)
		{
			randomVector = randomVector.Multiply(LensRadius);
			Vector vectorOffSet = VectorU
				.Multiply(randomVector.X)
				.Add(VectorV.Multiply(randomVector.Y));

			Vector horizontalPosition = VectorHorizontal.Multiply(u);
			Vector verticalPosition = VectorVertical.Multiply(v);

			Vector pointPosition = VectorLowerLeftCorner
				.Add(horizontalPosition.Add(verticalPosition))
				.Substract(Origin)
				.Substract(vectorOffSet);

			return new Ray()
			{
				Origin = Origin.Add(vectorOffSet),
				Direction = pointPosition
			};
		}
	}
}
