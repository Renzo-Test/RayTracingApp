using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Engine.Exporter;

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

    }
}
