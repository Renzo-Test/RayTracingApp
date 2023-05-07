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



    }
}
