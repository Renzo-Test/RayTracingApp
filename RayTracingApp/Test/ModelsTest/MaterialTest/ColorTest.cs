using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.MaterialExceptions;

namespace Test.ModelsTest
{
    [TestClass]
    public class ColorTest
    {
        private Color _newColor;

        [TestMethod]
        public void SetRed_ValidNumber_OkTest()
        {
            _newColor = new Color()
            {
                Red = 222,
            };

            Assert.AreEqual(222, _newColor.Red);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetRed_GreaterNumber_FailTest()
        {
            _newColor = new Color()
            {
                Red = 256,
            };

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetRed_LowerNumber_FailTest()
        {
            _newColor = new Color()
            {
                Red = -1,
            };

        }

        [TestMethod]
        public void SetGreen_ValidNumber_OkTest()
        {
            _newColor = new Color()
            {
                Green = 222,
            };

            Assert.AreEqual(222, _newColor.Green);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetGreen_GreaterNumber_FailTest()
        {
            _newColor = new Color()
            {
                Green = 256,
            };

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetGreen_LowerNumber_FailTest()
        {
            _newColor = new Color()
            {
                Green = -1,
            };

        }

        [TestMethod]
        public void SetBlue_ValidNumber_OkTest()
        {
            _newColor = new Color()
            {
                Blue = 222,
            };

            Assert.AreEqual(222, _newColor.Blue);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetBlue_GreaterNumber_FailTest()
        {
            _newColor = new Color()
            {
                Green = 256,
            };

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetBlue_LowerNumber_FailTest()
        {
            _newColor = new Color()
            {
                Green = -1,
            };

        }
    }
}
