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

		private Camera _camera;

		private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

		public string Render(Scene scene, RenderProperties properties)
		{
			_progress = new Progress();
			_pixels = new List<List<Vector>>();
			_printer = new Printer();

			_progress.ExpectedLines = (properties.ResolutionY * properties.ResolutionX * properties.SamplesPerPixel) + properties.ResolutionY;


			double AspectRatio = properties.AspectRatio;

			//created before iterate
			for (int i = 0; i < properties.ResolutionY; i++)
			{
				_pixels.Add(new List<Vector>());
			}

			int row = properties.ResolutionY - 1;
			Parallel.For(0, row + 1, index =>
			{
				int derivatedIndex = row - index;
				for (int column = 0; column < properties.ResolutionX; column++)
				{
					Vector vector = new Vector() //no pongo constructor por clean code
					{
						X = 0,
						Y = 0,
						Z = 0
					};

					for (int sample = 0; sample < properties.SamplesPerPixel; sample++)
					{
						double fstRnd = random.Value.NextDouble();
						double sndRnd = random.Value.NextDouble();

						double u = (column + fstRnd) / properties.ResolutionX;
						double v = (derivatedIndex + sndRnd) / properties.ResolutionY;

						var ray = _camera.GetRay(u, v);
						vector.AddFrom(ShootRay(ray, properties.MaxDepth));
						_progress.Count(); ;
					}

					vector = vector.Divide(properties.SamplesPerPixel);
					Vector color = new Vector();
					SavePixel(derivatedIndex, column, color);
				}
			});
			return _printer.Save(_pixels, properties, ref _progress);
		}
	}
}
