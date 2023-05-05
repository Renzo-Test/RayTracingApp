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
    }
}
