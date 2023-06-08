using Engine.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
