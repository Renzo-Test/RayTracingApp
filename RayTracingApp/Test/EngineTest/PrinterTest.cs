using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
using System;
using Engine.RenderProperties;

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
                ResolutionX = 0,
                ResolutionY = 0,
                
            };
            printer.InitializeImageProperties(properties);
            string expected = $"P3\n 0 0 \n255\n";

            Assert.AreEqual(expected, printer.Save(null, properties, null));
		}
    }
}
