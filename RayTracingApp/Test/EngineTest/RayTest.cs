using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class RayTest
    {
        [TestMethod]
        public void CreateRay_OkTest()
        {
            Ray ray = new Ray();
        }

        [TestMethod]
        public void SetOrigin_OkTest()
        {
            Ray ray = new Ray();

            Vector vector = new Vector();
            ray.Origin = vector;

            Assert.AreEqual(vector, ray.Origin);
        }

        [TestMethod]
        public void SetDirection_OkTest()
        {
            Ray ray = new Ray();

            Vector vector = new Vector();
            ray.Direction = vector;

            Assert.AreEqual(vector, ray.Direction);
        }
    }
}
