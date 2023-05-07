using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class RenderProperties
	{
		public int ResolutionX { get; set; } = 300;
		public int ResolutionY { get; set; } = 200;

		public double AspectRatio()
		{
			return 1.5;
		}
	}
}
