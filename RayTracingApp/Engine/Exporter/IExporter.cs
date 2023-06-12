using System.Drawing;

namespace Engine.Exporter
{
	public interface IExporter
	{
		void Export(string path, Image img);
	}
}
