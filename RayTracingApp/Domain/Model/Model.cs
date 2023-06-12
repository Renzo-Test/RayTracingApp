using Domain.Exceptions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Domain
{
	public class Model
	{
		private const string SpaceCharacterConstant = " ";
		private const string NotAlphanumericMessage = "Model's name must not start or end with blank space";
		private const string EmptyNameMessage = "Model's name must not be empty";

		public int Id { get; set; }


		private string _owner;
		private string _name;
		private Figure _figure;
		private Material _material;
		public byte[] Preview { get; set; }
		public bool showPreview { get; set; }

		public string Owner
		{
			get => _owner;
			set => _owner = value;
		}

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

		public Image GetPreview()
		{
			using (var stream = new MemoryStream(Preview))
			{
				return Image.FromStream(stream);
			}
		}

		public void SetPreview(Image img)
		{
			Preview = ImageToByteArray(img);
		}

		public byte[] ImageToByteArray(Image img)
		{
			using (var stream = new MemoryStream())
			{
				img.Save(stream, ImageFormat.Bmp);
				return stream.ToArray();
			}
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
