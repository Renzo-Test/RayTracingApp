using Domain.Exceptions;

namespace Domain
{
	public class Metalic : Material
	{
		public const string NotValidBlurMessage = "Blur value must be greater or equal than 0.0";

		public Metalic() : base(MaterialEnum.Metallic) { }

		private double _blur;
		public double Blur
		{
			get { return _blur; }
			set
			{
				try
				{
					RunBlurIsValidChecker(value);
					_blur = value;
				}
				catch (InvalidMaterialInputException ex)
				{
					throw new InvalidMaterialInputException(ex.Message);
				}
			}
		}

		private static void RunBlurIsValidChecker(double value)
		{
			if (value < 0.0)
			{
				throw new InvalidMaterialInputException(NotValidBlurMessage);
			}
		}
	}
}
