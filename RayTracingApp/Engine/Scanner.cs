using System.Drawing;
using System.IO;

namespace Engine
{
	public class Scanner
	{
        private const char Splitter = ' ';
		private const int firstPosition = 0;
		private const int secondPosition = 1;
		private const int thirdPosition = 2;


		public Bitmap ScanImage(string ppmImage)
		{
			StringReader imgReader = new StringReader(ppmImage);

			_ = GetVersion(imgReader);
			var (width, height) = GetDimensions(imgReader);
			_ = GetMaxPixelValue(imgReader);

			Bitmap image = new Bitmap(width, height);

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					var (red, green, blue) = GetPixelColor(imgReader);
					image.SetPixel(x, y, CreateColor(red, green, blue));
				}
			}

			return image;
		}

		private static (int, int) GetDimensions(StringReader imgReader)
		{
			string line = imgReader.ReadLine();
			string[] dimensions = line.Split(Splitter);

			int width = int.Parse(dimensions[firstPosition]);
			int height = int.Parse(dimensions[secondPosition]);

			return (width, height);
		}

		private static string GetVersion(StringReader imgReader)
		{
			return imgReader.ReadLine();
		}

		private static int GetMaxPixelValue(StringReader imgReader)
		{
			string line = imgReader.ReadLine();
			return int.Parse(line);
		}
		private static (int, int, int) GetPixelColor(StringReader imgReader)
		{
			string line = imgReader.ReadLine();
			string[] colors = line.Split(Splitter);

			int r = int.Parse(colors[firstPosition]);
			int g = int.Parse(colors[secondPosition]);
			int b = int.Parse(colors[thirdPosition]);

			return (r, g, b);
		}
		static Color CreateColor(int red, int green, int blue)
		{
			return Color.FromArgb(red, green, blue);
		}
	}
}
