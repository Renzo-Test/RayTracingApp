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
    }
}
