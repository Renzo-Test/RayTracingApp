using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
