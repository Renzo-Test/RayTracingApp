using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Engine.Exporter;
using System.Drawing;
using System.IO;


namespace Test.EngineTest
{
    [TestClass]
    public class ExporterTest
    {
        [TestMethod]
        public void CanCreateJPGExporter_OkTest()
        {
            IExporter exporter = new JPGExporter();
        }

        [TestMethod]
        public void CanExport_JPGExporter_OkTest()
        {
            IExporter exporter = new JPGExporter();
            exporter.Export(Path.Combine(Directory.GetCurrentDirectory(), "image.jpg"), new Bitmap(800, 600));
        }


    }
}
