using Controller;
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
		private const string TestDatabase = "RayTracingAppTestDB";

		private MaterialRepository _materialRepository;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
			_materialRepository = new MaterialRepository()
			{
				DBName = TestDatabase
			};
			_clientController = new ClientController(TestDatabase);

			_clientController.SignUp("ownerName", "Password123");
			_owner = _clientController.SignIn("ownerName", "Password123");

			_otherOwner = new Client() { Username = "otherName" };
		}

		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Materials");
				context.ClearDBTable("Clients");
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
				Owner = _owner,
				Color = NewColor,
			};

			_materialRepository.AddMaterial(NewMaterial, _owner);

			Assert.AreEqual(NewMaterial.Name, _materialRepository.GetMaterialsByClient(_owner)[0].Name);
			Assert.AreEqual(NewMaterial.Owner.Id, _materialRepository.GetMaterialsByClient(_owner)[0].Owner.Id);
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
				Color = NewColor,
			};

			_materialRepository.AddMaterial(NewMaterial, _owner);

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
				Owner = _owner,
				Color = NewColor,
			};


			_materialRepository.AddMaterial(NewMaterial, _owner);
			_materialRepository.RemoveMaterial(NewMaterial);
			List<Material> materials = _materialRepository.GetMaterialsByClient(_owner);

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
				Owner = _owner,
				Color = NewColor,
			};

			_materialRepository.RemoveMaterial(NewMaterial);
			List<Material> materials = _materialRepository.GetMaterialsByClient(_owner);

			Assert.IsFalse(materials.Any());
		}
	}
}
