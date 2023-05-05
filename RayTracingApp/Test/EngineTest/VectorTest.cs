using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void CreateVector_OkTest()
        {
            Vector vector = new Vector();
        }

        [TestMethod]
        public void SetX_int_OkTest()
        {
            Vector vector = new Vector();
            vector.X = 1;
        }

        [TestMethod]
        public void SetX_double_OkTest()
        {
            Vector vector = new Vector();
            vector.X = 1.5;
        }
    }
}
