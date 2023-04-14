using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.ModelTest
{
    [TestClass]
    public class ColorTest
    {
        [TestMethod]
        public void SetRed_ValidNumber_OkTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
            };

            Assert.AreEqual(222, NewColor.Red);
        }
    }
}
