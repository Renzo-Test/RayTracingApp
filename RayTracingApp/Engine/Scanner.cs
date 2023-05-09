using System.Drawing;
using System.IO;

namespace Engine
{
    public class Scanner
    {
        public Bitmap ScanImage(string ppmImage)
        {
            StringReader imgReader = new StringReader(ppmImage);

            string ppmVersion = GetVersion(imgReader);
            var (width, height) = GetDimensions(imgReader);
            int maxPixelValue  = GetMaxPixelValue(imgReader);

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
            string[] dimensions = line.Split(' ');

            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);

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
            string[] colors = line.Split(' ');

            int r = int.Parse(colors[0]);
            int g = int.Parse(colors[1]);
            int b = int.Parse(colors[2]);

            return (r, g, b);
        }
        static Color CreateColor(int red, int green, int blue)
        {
            return Color.FromArgb(red, green, blue);
        }
    }
}
