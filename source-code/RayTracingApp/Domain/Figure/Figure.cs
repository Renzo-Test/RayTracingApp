using Domain.Exceptions;

namespace Domain
{
	public abstract class Figure
	{
		private const string NotAlphanumericExceptionMessage = "Figure's name must have no spaces";
		private const string NotInExpectedRangeExceptionMessage = "Figure's name must not be empty";
		private const string SpaceCharacterConstant = " ";

		public int Id { get; set; }

		private Client _owner;
		public Client Owner
		{
			get => _owner;
			set => _owner = value;
		}

		private string _name;
		public string Name
		{
			get => _name;
			set
			{
				try
				{
					RunEmptyNameChecker(value);
					RunSpacedNameChecker(value);
					_name = value;
				}
				catch (InvalidFigureInputException ex)
				{
					throw new InvalidFigureInputException(ex.Message);
				}
			}
		}

		public abstract void FigurePropertiesAreValid();

		private static void RunEmptyNameChecker(string figureName)
		{
			if (string.IsNullOrEmpty(figureName))
			{
				throw new NotInExpectedRangeFigureException(NotInExpectedRangeExceptionMessage);
			}
		}

		private static void RunSpacedNameChecker(string figureName)
		{
			if (figureName.Contains(SpaceCharacterConstant))
			{
				throw new NotAlphanumericFigureException(NotAlphanumericExceptionMessage);
			}
		}
	}
}
