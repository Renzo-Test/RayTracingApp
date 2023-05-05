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
            _vector = new Vector()
            {
                X = 1,
                Y = 1,
            };
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
            Assert.AreEqual(1, _vector.X);
        }

        [TestMethod]
        public void SetX_double_OkTest()
        {
            _vector.X = 1.5;
            Assert.AreEqual(1.5, _vector.X);
        }

        [TestMethod]
        public void SetY_int_OkTest()
        {
            _vector.Y = 1;
            Assert.AreEqual(1, _vector.Y);
        }

        [TestMethod]
        public void SetY_double_OkTest()
        {
            _vector.Y = 1.5;
            Assert.AreEqual(1.5, _vector.Y);
        }

        [TestMethod]
        public void SetZ_int_OkTest()
        {
            _vector.Z = 1;
            Assert.AreEqual(1, _vector.Z);
        }

        [TestMethod]
        public void SetZ_double_OkTest()
        {
            _vector.Z = 1.5;
            Assert.AreEqual(1.5, _vector.Z);
        }

        [TestMethod]
        public void AddX_OkTest()
        {
            Vector vectorToAdd = new Vector()
            {
                X = 1,
            };
            Vector finalVector = _vector.Add(vectorToAdd);
            Assert.AreEqual(2, finalVector.X);
        }

        [TestMethod]
        public void AddY_OkTest()
        {
            Vector vectorToAdd = new Vector()
            {
                Y = 1,
            };
            Vector finalVector = _vector.Add(vectorToAdd);
            Assert.AreEqual(2, finalVector.Y);
        }
    }
}
