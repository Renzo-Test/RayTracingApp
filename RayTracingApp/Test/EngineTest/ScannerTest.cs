using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Test.EngineTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ScannerTest
    {
        private Scanner _scanner;

        [TestInitialize]
        public void TestInitialize()
        {
            _scanner = new Scanner();
        }

        [TestMethod]
        public void CreateScanner_OkTest()
        {
            _scanner = new Scanner();
        }

    }
}
