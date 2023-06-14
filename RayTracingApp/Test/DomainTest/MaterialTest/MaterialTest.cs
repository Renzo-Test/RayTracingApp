using Domain;
using Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]

	public class MaterialTest
	{
		private Material _material;
		private Client _owner;

		[TestInitialize]
		public void TestInitialize()
		{
			_owner = new Client() { Username = "ownerName" };
		}

		[TestMethod]
		public void CanCreateMaterial_OkTest()
		{
			_material = new Lambertian();
		}

		[TestMethod]
		public void SetOwner_Gomez_OkTest()
		{
			_material = new Lambertian()
			{
				Owner = _owner,
			};
			Assert.AreEqual(_owner.Username, _material.Owner.Username);
		}

		[TestMethod]
		public void SetName_Brick_OkTest()
		{
			_material = new Lambertian()
			{
				Name = "Brick",
			};
			Assert.AreEqual("Brick", _material.Name);
		}

		[TestMethod]
		public void SetColor_validColor_OkTest()
		{
			Color _newColor = new Color();

			_material = new Lambertian()
			{
				Color = _newColor,
			};

			Assert.AreEqual(_newColor, _material.Color);
		}

		[TestMethod]
		public void SetType_OkTest()
		{
			MaterialEnum emptyEnum = new MaterialEnum();

			_material = new Lambertian()
			{
				Type = emptyEnum
			};

			Assert.AreEqual(emptyEnum, _material.Type);
		}

		[TestMethod]
		public void CanCreateMetallicMaterial_OkTest()
		{
			_material = new Metalic();
		}

		[TestMethod]
		public void SetBlur_ValidBlur_OkTest()
		{
			_material = new Metalic()
			{
				Blur = 0.1
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void SetBlur_InvalidBlur_OkTest()
		{
			_material = new Metalic()
			{
				Blur = -0.1
			};
		}
	}
}
