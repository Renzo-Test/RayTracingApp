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
        private List<List<Color>> pixels;
        private Printer printer;

        [TestInitialize]
        public void TestInitialize()
        {
            pixels = new List<List<Color>>();
            printer = new Printer();
        }

		[TestMethod]
        public void CreatePrinter_OkTest()
        {
            Printer printer = new Printer();
        }

        [TestMethod]
        public void InitializeImageParameters_OkTest()
        {
            RenderProperties properties = new RenderProperties()
            {
                ResolutionX = 1,
                ResolutionY = 1,
            };
			Progress progress = new Progress();

			string expected = $"P3\n1 1\n255\n";
            Assert.AreEqual(expected, printer.Save(pixels, properties, ref progress));
		}

		[TestMethod]
		public void Save_OkTest()
		{
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 1,
				ResolutionY = 1,

			};
            Color color = new Color()
            {
                Red = 100,
                Green = 100,
                Blue = 100,
            };
            pixels.Add(new List<Color> { color });
            Progress progress = new Progress();

			string expected = $"P3\n1 1\n255\n100 100 100\n";
			Assert.AreEqual(expected, printer.Save(pixels, properties, ref progress));
		}

        [TestMethod]
        public void Progress_OkTest()
        {
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 1,
				ResolutionY = 1,

			};
			Color color = new Color()
			{
				Red = 100,
				Green = 100,
				Blue = 100,
			};
			pixels.Add(new List<Color> { color });
            Progress progress = new Progress()
            {
                ExpectedLines = 1,
            };

			printer.Save(pixels, properties, ref progress);
			Assert.AreEqual(100, progress.Calculate());
		}
	}
}
