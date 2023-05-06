using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class RayTest
    {
        private Ray _ray;
        private Vector _vector;

        [TestInitialize]
        public void TestInitialize()
        {
            _ray = new Ray();
            _vector = new Vector();
        }

        [TestMethod]
        public void CreateRay_OkTest()
        {
            Ray ray = new Ray();
        }

        [TestMethod]
        public void SetOrigin_OkTest()
        {
            _ray.Origin = _vector;

            Assert.AreEqual(_vector, _ray.Origin);
        }

        [TestMethod]
        public void SetDirection_OkTest()
        {
            _ray.Direction = _vector;

            Assert.AreEqual(_vector, _ray.Direction);
        }

        [TestMethod]
        public void PointAt_OkTest()
        {
            Vector origin = new Vector()
            {
                X = 1,
                Y = 1,
                Z = 2,
            };
            Vector direction = new Vector()
            {
                X = 2,
                Y = 3,
                Z = 0,
            };

            _ray.Origin = origin;
            _ray.Direction = direction;

            Vector expected = new Vector()
            {
                X = 5,
                Y = 7,
                Z = 2,
            };
            Vector actual = _ray.PointAt(2);
        }

        [TestMethod]
        public void PointAt_anotherVector_OkTest()
        {
            Vector origin = new Vector()
            {
                X = 0,
                Y = 0,
                Z = 1,
            };
            Vector direction = new Vector()
            {
                X = 0,
                Y = 4,
                Z = 3,
            };

            _ray.Origin = origin;
            _ray.Direction = direction;

            Vector expected = new Vector()
            {
                X = 0,
                Y = 16,
                Z = 13,
            };
            Vector actual = _ray.PointAt(4);
        }
    }
}
