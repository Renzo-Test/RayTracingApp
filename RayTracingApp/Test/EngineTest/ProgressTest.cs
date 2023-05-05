using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class ProgressTest
    {
        private Progress _progress;

        [TestInitialize]
        public void TestInitialize()
        {
            _progress = new Progress();
        }

        [TestMethod]
        public void CreateProgress_OkTest()
        {
            Progress progress = new Progress();
        }

        [TestMethod]
        public void SetLinesCount_OkTest()
        {
            Progress _progress = new Progress();
            _progress.LinesCount = 0;

            Assert.AreEqual(0, _progress.LinesCount);
        }

        [TestMethod]
        public void SetLinesCount_uint_OkTest()
        {
            Progress _progress = new Progress();
            _progress.LinesCount = 2147483648;

            Assert.AreEqual(2147483648, _progress.LinesCount);
        }

        [TestMethod]
        public void SetLinesCount_long_OkTest()
        {
            Progress _progress = new Progress();
            _progress.LinesCount = 4294967296;

            Assert.AreEqual(4294967296, _progress.LinesCount);
        }

        [TestMethod]
        public void Count_OkTest()
        {
            Progress _progress = new Progress();

            int linesToCount = 5000;
            for (int i = 0; i < linesToCount; i++)
            {
                _progress.Count();
            }

            Assert.AreEqual(5000, _progress.LinesCount);
        }

        [TestMethod]
        public void Count_otherValue_OkTest()
        {
            Progress _progress = new Progress();

            int linesToCount = 999999;
            for (int i = 0; i < linesToCount; i++)
            {
                _progress.Count();
            }

            Assert.AreEqual(999999, _progress.LinesCount);
        }
    }
}
