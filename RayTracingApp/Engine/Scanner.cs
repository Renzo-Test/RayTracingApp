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

            string ppmVersion = imgReader.ReadLine();
            string line = imgReader.ReadLine();
            string[] dimensions = line.Split(' ');

            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);

            Bitmap image = new Bitmap(width, height);

            return image;
        }
    }
}
