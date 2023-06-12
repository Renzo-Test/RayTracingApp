using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Test.MemoryRepositoryTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class MaterialRepositoryTest
	{
		private MaterialRepository _materialRepository;

		[TestInitialize]
		public void TestInitialize()
		{
			_materialRepository = new MaterialRepository()
			{
				DBName = "RayTracingAppTestDB"
			};
		}

		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Materials");
			}
		}

		[TestMethod]
		public void GetFiguresByClient_OwnerName_OkTest()
		{
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = "OwnerName",
				Color = NewColor,
			};

			_materialRepository.AddMaterial(NewMaterial);

			Assert.AreEqual(NewMaterial.Name, _materialRepository.GetMaterialsByClient("OwnerName")[0].Name);
			Assert.AreEqual(NewMaterial.Owner, _materialRepository.GetMaterialsByClient("OwnerName")[0].Owner);
		}

		[TestMethod]
		public void AddMaterial_OkTest()
		{
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = "OwnerName",
				Color = NewColor,
			};

			_materialRepository.AddMaterial(NewMaterial);

		}

		[TestMethod]
		public void RemoveMaterial_OkTestt()
		{

			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = "OwnerName",
				Color = NewColor,
			};


			_materialRepository.AddMaterial(NewMaterial);
			_materialRepository.RemoveMaterial(NewMaterial);
			List<Material> materials = _materialRepository.GetMaterialsByClient("OwnerName");

			Assert.IsFalse(materials.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundMaterialException))]
		public void RemoveMaterial_NotExistingMaterial_OkTest()
		{
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = "OwnerName",
				Color = NewColor,
			};

			_materialRepository.RemoveMaterial(NewMaterial);
			List<Material> materials = _materialRepository.GetMaterialsByClient("OwnerName");

			Assert.IsFalse(materials.Any());
		}
	}
}
