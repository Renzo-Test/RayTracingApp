using Domain.Exceptions;
using System;

namespace Domain
{
	public class Model
	{
		private const string SpaceCharacterConstant = " ";
		private const string NotAlphanumericMessage = "Model's name must not start or end with blank space";
		private const string EmptyNameMessage = "Model's name must not be empty";

		private String _owner;
		private String _name;
		private Figure _figure;
		private Material _material;
		
		public string Preview { get; set; }
		
		public bool showPreview { get; set; }

		public int Id { get; set; }
		
		public String Owner
		{
			get => _owner;
			set => _owner = value;
		}
		public String Name
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
				catch (InvalidModelInputException ex)
				{
					throw new InvalidModelInputException(ex.Message);
				}
			}
		}
		public Figure Figure
		{
			get => _figure;
			set => _figure = value;
		}
		public Material Material
		{
			get => _material;
			set => _material = value;
		}

		private static void RunNameIsSpacedChecker(string value)
		{
			if (value.StartsWith(SpaceCharacterConstant) || value.EndsWith(SpaceCharacterConstant))
			{
				throw new NotAlphanumericException(NotAlphanumericMessage);
			}
		}
		private static void RunNameIsEmptyChecker(string value)
		{
			if (value.Equals(string.Empty))
			{
				throw new EmptyNameModelException(EmptyNameMessage);
			}
		}
	}
}
