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

            Assert.AreEqual(0, progress.LinesCount);
        }
    }
}
