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
        [TestMethod]
        public void CreateScanner_OkTest()
        {
            Scanner scanner = new Scanner();
        }

    }
}
