using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

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

     
    }
}
