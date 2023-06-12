using Domain.Exceptions;

namespace Domain
{
	public class Color
	{
		private const string ColorErrorMessage = "Color's number must not be smaller than 0 or greater than 255";

		private int _red = 0;
		public int Red
		{
			get => _red;
			set
			{
				if (IsInvalid(value))
				{
					throw new InvalidColorNumberException(ColorErrorMessage);
				}
				_red = value;
			}
		}

		private int _green = 0;
		public int Green
		{
			get => _green;
			set
			{
				if (IsInvalid(value))
				{
					throw new InvalidColorNumberException(ColorErrorMessage);
				}
				_green = value;
			}
		}

		private int _blue = 0;
		public int Blue
		{
			get => _blue;
			set
			{
				if (IsInvalid(value))
				{
					throw new InvalidColorNumberException(ColorErrorMessage);
				}
				_blue = value;
			}
		}

		public Vector ColorToVector()
		{
			Vector colorVector = new Vector()
			{
				X = ColorToAxis(Red),
				Y = ColorToAxis(Green),
				Z = ColorToAxis(Blue),
			};

			return colorVector;
		}


		private double ColorToAxis(int color)
		{
			return (double)color / 255;
		}

		private static bool IsInvalid(int value)
		{
			return value < 0 || value > 255;
		}
	}
}
