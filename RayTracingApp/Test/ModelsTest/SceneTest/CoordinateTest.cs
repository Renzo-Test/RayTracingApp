using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;


namespace Test.ModelsTest
{
    [TestClass]
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


    }
}
