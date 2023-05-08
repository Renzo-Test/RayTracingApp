using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
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

        [TestMethod]
        public void InitializeImageParameters_OkTest()
        {
            Printer printer = new Printer();
            RenderProperties properties = new RenderProperties()
            {
                ResolutionX = 1,
                ResolutionY = 1,
                
            };

            string expected = $"P3\n 1 1 \n255\n";
            Assert.AreEqual(expected, printer.Save(null, properties, null));
		}
    }
}
