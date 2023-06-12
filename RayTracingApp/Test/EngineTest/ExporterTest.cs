using Engine.Exceptions;
using Engine.Exporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

			string testPath = Path.Combine(Directory.GetCurrentDirectory(), "image.jpg");
			Image testImage = new Bitmap(800, 600);

			exporter.Export(testPath, testImage);
		}

		[TestMethod]
		[ExpectedException(typeof(ExporterException))]
		public void CanExport_JPGExporter_FailTest()
		{
			IExporter exporter = new JPGExporter();
			Image testImage = new Bitmap(800, 600);

			exporter.Export("", testImage);
		}

		[TestMethod]
		public void CanCreatePNGExporter_OkTest()
		{
			IExporter exporter = new PNGExporter();
		}

		[TestMethod]
		public void CanExport_PNGExporter_OkTest()
		{
			IExporter exporter = new PNGExporter();

			string testPath = Path.Combine(Directory.GetCurrentDirectory(), "image.jpg");
			Image testImage = new Bitmap(800, 600);

			exporter.Export(testPath, testImage);
		}

		[TestMethod]
		[ExpectedException(typeof(ExporterException))]
		public void CanExport_PNGExporter_FailTest()
		{
			IExporter exporter = new PNGExporter();
			Image testImage = new Bitmap(800, 600);

			exporter.Export("", testImage);
		}

		[TestMethod]
		public void CanCreatePPMExporter_OkTest()
		{
			IExporter exporter = new PPMExporter();
		}

		[TestMethod]
		public void CanExport_PPMExporter_OkTest()
		{
			IExporter exporter = new PPMExporter();

			string testPath = Path.Combine(Directory.GetCurrentDirectory(), "image.jpg");
			Image testImage = new Bitmap(800, 600);

			exporter.Export(testPath, testImage);
		}

		[TestMethod]
		[ExpectedException(typeof(ExporterException))]
		public void CanExport_PPMExporter_FailTest()
		{
			IExporter exporter = new PPMExporter();
			Image testImage = new Bitmap(800, 600);

			exporter.Export("", testImage);
		}

	}
}
