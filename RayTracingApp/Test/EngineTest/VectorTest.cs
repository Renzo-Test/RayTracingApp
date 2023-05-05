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
                Z = 1,
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

        [TestMethod]
        public void AddZ_OkTest()
        {
            Vector vectorToAdd = new Vector()
            {
                Z = 1,
            };
            Vector finalVector = _vector.Add(vectorToAdd);
            Assert.AreEqual(2, finalVector.Z);
        }

        [TestMethod]
        public void Substract_OkTest()
        {
            Vector vectorToSubstract = new Vector()
            {
                Z = 2,
            };
            Vector finalVector = _vector.Substract(vectorToSubstract);
            Assert.AreEqual(-1, finalVector.Z);
        }

        [TestMethod]
        public void Multiply_OkTest()
        {
            double multiplier = 1.5;
            Vector finalVector = _vector.Multiply(multiplier);
            Assert.AreEqual(1.5, finalVector.X);
            Assert.AreEqual(1.5, finalVector.Y);
            Assert.AreEqual(1.5, finalVector.Z);
        }

        [TestMethod]
        public void Divide_OkTest()
        {
            double divisor = 2;
            Vector finalVector = _vector.Divide(divisor);
            Assert.AreEqual(0.5, finalVector.X);
            Assert.AreEqual(0.5, finalVector.Y);
            Assert.AreEqual(0.5, finalVector.Z);
        }

        [TestMethod]
        public void AddFrom_OkTest()
        {
            Vector vectorToAdd = new Vector()
            {
                X = 1,
                Y = 2,
                Z = 3,
            };
            _vector.AddFrom(vectorToAdd);

            Assert.AreEqual(2, _vector.X);
            Assert.AreEqual(3, _vector.Y);
            Assert.AreEqual(4, _vector.Z);
        }

        [TestMethod]
        public void AddFrom_anotherVector_OkTest()
        {
            Vector vectorToAdd = new Vector()
            {
                X = 0,
                Y = 1,
                Z = 2,
            };
            _vector.AddFrom(vectorToAdd);

            Assert.AreEqual(1, _vector.X);
            Assert.AreEqual(2, _vector.Y);
            Assert.AreEqual(3, _vector.Z);
        }

        [TestMethod]
        public void SubstractFrom_OkTest()
        {
            Vector vectorToSubstract = new Vector()
            {
                X = 1,
                Y = 2,
                Z = 3,
            };
            _vector.SubstractFrom(vectorToSubstract);

            Assert.AreEqual(0, _vector.X);
            Assert.AreEqual(-1, _vector.Y);
            Assert.AreEqual(-2, _vector.Z);
        }

        [TestMethod]
        public void SubstractFrom_anotherVector_OkTest()
        {
            Vector vectorToSubstract = new Vector()
            {
                X = 0,
                Y = 1,
                Z = 2,
            };
            _vector.SubstractFrom(vectorToSubstract);

            Assert.AreEqual(1, _vector.X);
            Assert.AreEqual(0, _vector.Y);
            Assert.AreEqual(-1, _vector.Z);
        }

        [TestMethod]
        public void ScaleUpBy_OkTest()
        {
            double multiplier = 2;
            _vector.ScaleUpBy(multiplier);

            Assert.AreEqual(2, _vector.X);
            Assert.AreEqual(2, _vector.Y);
            Assert.AreEqual(2, _vector.Z);
        }

        [TestMethod]
        public void ScaleUpBy_anotherDouble_OkTest()
        {
            double multiplier = 5;
            _vector.ScaleUpBy(multiplier);

            Assert.AreEqual(5, _vector.X);
            Assert.AreEqual(5, _vector.Y);
            Assert.AreEqual(5, _vector.Z);
        }

        [TestMethod]
        public void ScaleDownBy_OkTest()
        {
            double divisor = 2;
            _vector.ScaleDownBy(divisor);

            Assert.AreEqual(0.5, _vector.X);
            Assert.AreEqual(0.5, _vector.Y);
            Assert.AreEqual(0.5, _vector.Z);
        }

        [TestMethod]
        public void ScaleDownBy_anotherDouble_OkTest()
        {
            double divisor = 1;
            _vector.ScaleDownBy(divisor);

            Assert.AreEqual(1, _vector.X);
            Assert.AreEqual(1, _vector.Y);
            Assert.AreEqual(1, _vector.Z);
        }
    }
}
