using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
using System;
using System.Collections.Generic;
using Domain;
using System.Windows.Forms;

namespace Test.EngineTest
{
    [TestClass]
    public class PrinterTest
    {
        private List<List<Vector>> pixels;
        private Printer printer;

		[TestInitialize]
        public void TestInitialize()
        {
            pixels = new List<List<Vector>>();
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
            Vector color = new Vector()
            {
                X = 0.2,
                Y = 0.2,
                Z = 0.2,
            };
            pixels.Add(new List<Vector> { color });
            Progress progress = new Progress();
			string expected = $"P3\n1 1\n255\n51 51 51\n";
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
			Vector color = new Vector()
			{
				X = 1,
				Y = 1,
				Z = 1,
			};
			pixels.Add(new List<Vector> { color });
            Progress progress = new Progress()
            {
                ExpectedLines = 1,
            };

			printer.Save(pixels, properties, ref progress);
			Assert.AreEqual(100, progress.Calculate());
		}
	}
}
