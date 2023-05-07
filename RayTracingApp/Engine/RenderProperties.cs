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
				double aspectRatio = AspectRatio;
				_resolutionX = value;
				_resolutionY = (int)(_resolutionX / aspectRatio);
			}
		}

		private int _resolutionY = 200;
		public int ResolutionY
		{
			get
			{
				return _resolutionY;
			}
			set
			{
				double aspectRatio = AspectRatio;
				_resolutionY = value;
				_resolutionX = (int)(_resolutionY * aspectRatio);
			}
		}

		public double AspectRatio { get; set; } = 3 / 2;
	}
}
