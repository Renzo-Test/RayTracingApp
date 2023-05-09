using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine
{
	public class Renderer
	{
		private Printer _printer;
		private List<List<Vector>> _pixels;
		private Progress _progress;

		private readonly RenderProperties _properties;

		private Camera _camera;

		private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

		public string Render(Scene scene)
		{
			_progress = new Progress();
			_pixels = new List<List<Vector>>();
			_printer = new Printer();


			_progress.ExpectedLines = (_properties.ResolutionY * _properties.ResolutionX * _properties.SamplesPerPixel) + _properties.ResolutionY;


			double AspectRatio = _properties.AspectRatio;

			for (int i = 0; i < _properties.ResolutionY; i++)
			{
				_pixels.Add(new List<Vector>());
			}

			int row = _properties.ResolutionY - 1;
			Parallel.For(0, row + 1, index =>
			{
				int derivatedIndex = row - index;
				for (int column = 0; column < _properties.ResolutionX; column++)
				{
					Vector vector = new Vector()
					{
						X = 0,
						Y = 0,
						Z = 0
					};

					for (int sample = 0; sample < _properties.SamplesPerPixel; sample++)
					{
						double fstRnd = random.Value.NextDouble();
						double sndRnd = random.Value.NextDouble();

						double u = (column + fstRnd) / _properties.ResolutionX;
						double v = (derivatedIndex + sndRnd) / _properties.ResolutionY;

						var ray = _camera.GetRay(u, v);
						vector.AddFrom(ShootRay(ray, _properties.MaxDepth));
						_progress.Count(); ;
					}

					vector = vector.Divide(_properties.SamplesPerPixel);
					Vector color = new Vector();
					SavePixel(derivatedIndex, column, color);
				}
			});
			return _printer.Save(_pixels, _properties, ref _progress);
		}

		private void SavePixel(int row, int column, Vector pixelRGB)
		{
			int posX = column;
			int posY = _properties.ResolutionY - row - 1;

			if (posY < _properties.ResolutionY)
			{
				_pixels[posY].Add(pixelRGB);
			}
			else
			{
				throw new Exception("Pixel Overflow Error");
			}
		}
	}
}
