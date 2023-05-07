using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

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

        [TestMethod]
        public void CreateImage_OkTest()
        {
            Bitmap image = _scanner.ScanImage("P3\n1 1\n255\n255 0 0");

            Assert.AreEqual(image.Height, 1);
        }

        [TestMethod]
        public void CanReadMaxPixelValue_OkTest()
        {
            Bitmap image = _scanner.ScanImage("P3\n1 1\n255\n255 0 0");
        }

        [TestMethod]
        public void CanSetPixel_OkTest()
        {
            Bitmap image = _scanner.ScanImage("P3\n1 1\n255\n255 0 0");

            Color pixel = image.GetPixel(0, 0);
            Color expectedPixel = System.Drawing.Color.FromArgb(255, 0, 0);

            Assert.AreEqual(pixel, expectedPixel);
        }

        [TestMethod]
        public void CanSetPixel_MultiplePixels_OkTest()
        {
            Bitmap image = _scanner.ScanImage("P3\n2 1\n255\n255 0 0\n0 255 0");

            Color firstPixel = image.GetPixel(0, 0);
            Color secondPixel = image.GetPixel(0, 1);

            Color firstExpectedPixel = System.Drawing.Color.FromArgb(255, 0, 0);
            Color secondExpectedPixel = System.Drawing.Color.FromArgb(0, 255, 0);

            Assert.AreEqual(firstPixel, firstExpectedPixel);
            Assert.AreEqual(secondPixel, secondExpectedPixel);

        }



    }
}
