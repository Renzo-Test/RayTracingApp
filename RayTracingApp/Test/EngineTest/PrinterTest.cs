using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
using System;
using System.Collections.Generic;
using Models;

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

            string expected = $"P3\n1 1\n255\n";
            Assert.AreEqual(expected, printer.Save(null, properties, null));
		}

		[TestMethod]
		public void Save_OkTest()
		{
			Printer printer = new Printer();
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 1,
				ResolutionY = 1,

			};
            List<List<Color>> pixels = new List<List<Color>>();
            Color color = new Color()
            {
                Red = 100,
                Green = 100,
                Blue = 100,
            };
            pixels.Add(new List<Color> { color });

			string expected = $"P3\n1 1\n255\n100 100 100";
			Assert.AreEqual(expected, printer.Save(pixels, properties, null));
		}
	}
}
