using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class RenderProperties
	{
		private int _resolutionX = 300;
		public int ResolutionX
		{
			get
			{
				return _resolutionX;
			}
			set
			{
				double aspectRatio = AspectRatio();
				_resolutionX = value;
				ResolutionY = (int)(_resolutionX / aspectRatio);
			}
		}

		public int ResolutionY { get; set; } = 200;

		public double AspectRatio()
		{
			return (double)ResolutionX / ResolutionY;
		}
	}
}
