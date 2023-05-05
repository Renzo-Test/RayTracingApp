using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class VectorTest
    {
        private Vector _vector;

        [TestInitialize]
        public void TestInitialize()
        {
            _vector = new Vector();
        }

        [TestMethod]
        public void CreateVector_OkTest()
        {
            Vector vector = new Vector();
        }

        [TestMethod]
        public void SetX_int_OkTest()
        {
            _vector.X = 1;
        }

        [TestMethod]
        public void SetX_double_OkTest()
        {
            _vector.X = 1.5;
        }

        [TestMethod]
        public void SetY_int_OkTest()
        {
            _vector.Y = 1;
        }

        [TestMethod]
        public void SetY_double_OkTest()
        {
            _vector.Y = 1.5;
        }

        [TestMethod]
        public void SetZ_int_OkTest()
        {
            _vector.Z = 1;
        }
    }
}
