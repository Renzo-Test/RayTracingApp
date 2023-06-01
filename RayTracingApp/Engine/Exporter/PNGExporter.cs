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
                img.Save(path, ImageFormat.Png);
            }
            catch (Exception)
            {
                throw new ExporterException(InvalidPathErrorMessage);
            }
        }
    }
}
