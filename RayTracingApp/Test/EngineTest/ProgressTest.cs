using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class ProgressTest
    {
        [TestMethod]
        public void CreateProgress_OkTest()
        {
            Progress progress = new Progress();
        }

        [TestMethod]
        public void SetLinesCount_OkTest()
        {
            Progress progress = new Progress();
            progress.LinesCount = 0;
            uint expected = 0;

            Assert.AreEqual(expected, progress.LinesCount);
        }

        [TestMethod]
        public void SetLinesCount_uint_OkTest()
        {
            Progress progress = new Progress();
            progress.LinesCount = 2147483648;

            Assert.AreEqual(2147483648, progress.LinesCount);
        }

        [TestMethod]
        public void SetLinesCount_long_OkTest()
        {
            Progress progress = new Progress();
            progress.LinesCount = 4294967296;
        }
    }
}
