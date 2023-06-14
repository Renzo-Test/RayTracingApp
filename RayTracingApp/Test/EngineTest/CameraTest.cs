using Domain;
using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Test.EngineTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class CameraTest
	{
		[TestMethod]
		public void CanCreateCamera_OkTest()
		{
			Vector newVector = new Vector()
			{
				X = 10,
				Y = 20,
				Z = 30
			};

			int fieldOfView = 10;
			double aspectRatio = 10;

			Camera camera = new Camera(newVector, newVector, newVector, fieldOfView, aspectRatio, 0, 0);
		}

		[TestMethod]
		public void CanGetRay_OkTest()
		{
			Vector newVector = new Vector()
			{
				X = 10,
				Y = 20,
				Z = 30
			};

			int fieldOfView = 10;
			double aspectRatio = 10;
			Vector vector = new Vector()
			{
				X = 10,
				Y = 20,
				Z = 30
			};

			Camera camera = new Camera(newVector, newVector, newVector, fieldOfView, aspectRatio, 0, 0);

			Vector horizontalPosition = newVector.Multiply(1);
			Vector verticalPosition = newVector.Multiply(2);

			Vector pointPosition = newVector.Add(horizontalPosition.Add(verticalPosition));

			Ray newRay = new Ray()
			{
				Origin = newVector,
				Direction = pointPosition.Substract(newVector)
			};

			Ray cameraRay = camera.GetRay(1, 2, vector);

			Assert.AreEqual(cameraRay.Origin.X, newRay.Origin.X);
			Assert.AreEqual(newRay.Direction.Y, newRay.Direction.Y);
		}

	}
}
