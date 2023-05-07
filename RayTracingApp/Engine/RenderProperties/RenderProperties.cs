using Engine.RenderProperties.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.RenderProperties
{
	public class RenderProperties
	{
		private const string ValueLowerThanZero = "This value must be greater than zero";

		private int _resolutionX = 300;
		public int ResolutionX
		{
			get => _resolutionX;
			set
			{
				try
				{
					IsLowerThanZero(value);
					_resolutionX = value;
					_resolutionY = (int)(_resolutionX / AspectRatio);
				}
				catch (InvalidRenderPropertiesInputException ex)
				{
					throw new InvalidRenderPropertiesInputException(ex.Message);
				}
			}
		}

		private int _resolutionY = 200;
		public int ResolutionY
		{
			get => _resolutionY;
			set
			{
				try
				{
					IsLowerThanZero(value);
					_resolutionY = value;
					_resolutionX = (int)(_resolutionY * AspectRatio);
				}
				catch (InvalidRenderPropertiesInputException ex)
				{
					throw new InvalidRenderPropertiesInputException(ex.Message);
				}
			}

		}

		public double AspectRatio { get; set; } = 3.0 / 2.0;

		public int SamplesPerPixel { get; set; }

		private void IsLowerThanZero(int value)
		{
			if(value <= 0)
			{
				throw new InvalidRenderPropertiesInputException(ValueLowerThanZero);
			}
		}
	}
}
