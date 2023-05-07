using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class PrinterTest
    {
        [TestMethod]
        public void CreatePrinter_OkTest()
        {
            Printer printer = new Printer();
        }
    }
}
