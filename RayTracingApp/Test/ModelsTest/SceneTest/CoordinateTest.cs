using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class CoordinateTest
	{
		[TestMethod]
		public void CreateCoordinate_OkTest()
		{
			Coordinate newCoordinate = new Coordinate();
		}

		[TestMethod]
		public void SetX_OkTest()
		{
			Coordinate newCoordinate = new Coordinate()
			{
				X = 10,
			};

			Assert.AreEqual(10, newCoordinate.X);
		}

		[TestMethod]
		public void SetY_OkTest()
		{
			Coordinate newCoordinate = new Coordinate()
			{
				Y = 10,
			};

			Assert.AreEqual(10, newCoordinate.Y);
		}

		[TestMethod]
		public void SetZ_OkTest()
		{
			Coordinate newCoordinate = new Coordinate()
			{
				Z = 10,
			};

			Assert.AreEqual(10, newCoordinate.Z);
		}

	}
}
