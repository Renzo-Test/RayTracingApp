using Domain.Exceptions;

namespace Domain
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

		private int _samplesPerPixel = 50;
		public int SamplesPerPixel
		{
			get => _samplesPerPixel;
			set
			{
				try
				{
					IsLowerThanZero(value);
					_samplesPerPixel = value;
				}
				catch (InvalidRenderPropertiesInputException ex)
				{
					throw new InvalidRenderPropertiesInputException(ex.Message);
				}
			}
		}

		private int _maxDepth = 50;
		public int MaxDepth
		{
			get => _maxDepth;
			set
			{
				try
				{
					IsLowerThanZero(value);
					_maxDepth = value;
				}
				catch (InvalidRenderPropertiesInputException ex)
				{
					throw new InvalidRenderPropertiesInputException(ex.Message);
				}
			}
		}

		public int PreCalculateYResolution(int resX)
		{
			return (int)(resX / AspectRatio);
		}
		
		public int PreCalculateXResolution(int resY)
		{
			return (int)(resY * AspectRatio);

		}
		
		private void IsLowerThanZero(int value)
		{
			if (value <= 0)
			{
				throw new InputLowerThanZero(ValueLowerThanZero);
			}
		}
	}
}
