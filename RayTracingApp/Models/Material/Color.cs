using Domain.Exceptions;

namespace Domain
{
	public class Color
	{
		private const string ColorErrorMessage = "Color's number must not be smaller than 0 or greater than 255";
		private int _red;
		private int _green;
		private int _blue;

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

		private static bool IsInvalid(int value)
		{
			return value < 0 || value > 255;
		}
	}
}
