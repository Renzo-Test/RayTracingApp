using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using Model.Exceptions;

namespace Test.ModelTest
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
        public void SetRed_GreaterNumber_OkTest()
        {
            _newColor = new Color()
            {
                Red = 256,
            };

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidColorNumberException))]
        public void SetRed_LowerNumber_OkTest()
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
    }
}
