using Domain.Exceptions;

namespace Domain
{
	public abstract class Material
	{
		private const string EmptyNameMessage = "Material's name must not be empty";
		private const string NotAlphanumericMessage = "Material's name must not start or end with blank space";
		private const string SpaceCharacterConstant = " ";

		public int Id { get; set; }

		protected Material(MaterialEnum type)
		{
			Type = type;
		}

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
					RunNameIsEmptyChecker(value);
					RunNameIsSpacedChecker(value);
					_name = value;
				}
				catch (InvalidMaterialInputException ex)
				{
					throw new InvalidMaterialInputException(ex.Message);
				}
			}
		}

		private Color _color;

		public Color Color
		{
			get => _color;
			set => _color = value;
		}

		private MaterialEnum _type;
		public MaterialEnum Type
		{
			get => _type;
			set => _type = value;
		}

		private static void RunNameIsEmptyChecker(string value)
		{
			if (value.Equals(string.Empty))
			{
				throw new EmptyNameMaterialException(EmptyNameMessage);
			}
		}

		private static void RunNameIsSpacedChecker(string value)
		{
			if (value.StartsWith(SpaceCharacterConstant) || value.EndsWith(SpaceCharacterConstant))
			{
				throw new NotAlphanumericMaterialException(NotAlphanumericMessage);
			}
		}
	}

	public enum MaterialEnum
	{
		Lambertian,
		Metallic
	}
}
