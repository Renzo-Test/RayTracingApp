using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Exporter
{
    public interface IExporter
    {
        void Export(string path, Image img);
    }
}
