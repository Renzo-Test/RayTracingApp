using Engine.Exceptions;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Engine.Exporter
{
	public class PNGExporter : IExporter
	{
		private const string InvalidPathErrorMessage = "Invalid Path";

		public void Export(string path, Image img)
		{
			try
			{
				SaveImage(img, path);
			}
			catch (Exception)
			{
				throw new ExporterException(InvalidPathErrorMessage);
			}
		}

		private static void SaveImage(Image imagen, string path)
		{
			using (var bitmap = new Bitmap(imagen))
			{
				bitmap.Save(path, ImageFormat.Jpeg);
			}
		}
	}
}
