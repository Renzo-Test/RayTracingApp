using System;
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
            string line = imgReader.ReadLine();
            int maxPixelValue  = int.Parse(line);

            Bitmap image = new Bitmap(width, height);

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
    }
}
