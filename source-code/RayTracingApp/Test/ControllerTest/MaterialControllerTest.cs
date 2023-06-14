using Controller;
using Controller.Exceptions;
using DBRepository.Exceptions;
using Domain;
using Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class MaterialControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private MaterialController _materialController;
		private ModelController _modelController;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
			_materialController = new MaterialController(TestDatabase);
			_modelController = new ModelController(TestDatabase);
			_clientController = new ClientController(TestDatabase);

			_otherOwner = new Client() { Username = "otherName" };

			_clientController.SignUp("ownerName", "Password123");
			_owner = _clientController.SignIn("ownerName", "Password123");
		}


		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Models");
				context.ClearDBTable("Materials");
				context.ClearDBTable("Clients");
			}
		}

		[TestMethod]
		public void CreateClientController_OkTest()
		{
			_materialController = new MaterialController();
		}

		[TestMethod]
		public void AddMaterial_ValidLambertian_OkTest()
		{
			Material _newMaterial = new Lambertian()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				},
			};

			_materialController.AddMaterial(_newMaterial, _owner);

			Assert.AreEqual(_materialController.Repository.GetMaterialsByClient(_owner)[0].Name, _newMaterial.Name);
		}

		[TestMethod]
		public void AddMaterial_ValidMetallic_OkTest()
		{
			Material _newMaterial = new Metalic()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				},
				Blur = 0.1
			};

			_materialController.AddMaterial(_newMaterial, _owner);

			Assert.AreEqual(_materialController.Repository.GetMaterialsByClient(_owner)[0].Name, _newMaterial.Name);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void AddMaterial_DuplicatedLambertian_FailTest()
		{
			Material _newMaterial = new Lambertian()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			_materialController.AddMaterial(_newMaterial, _owner);
			_materialController.AddMaterial(_newMaterial, _owner);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void AddMaterial_DuplicatedMetallic_FailTest()
		{
			Material _newMaterial = new Metalic()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				},
				Blur = 0.1
			};

			_materialController.AddMaterial(_newMaterial, _owner);
			_materialController.AddMaterial(_newMaterial, _owner);
		}

		[TestMethod]
		public void AddMaterial_TwoValidLambertians_OkTest()
		{
			Material _firstMaterial = new Lambertian()
			{
				Name = "materialOne",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			Material _secondMaterial = new Lambertian()
			{
				Name = "materialTwo",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			_materialController.AddMaterial(_firstMaterial, _owner);
			_materialController.AddMaterial(_secondMaterial, _owner);

			Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient(_owner).Count);
		}

		[TestMethod]
		public void AddMaterial_TwoValidMetallics_OkTest()
		{
			Material _firstMaterial = new Metalic()
			{
				Name = "materialOne",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				},
				Blur = 0.1
			};

			Material _secondMaterial = new Metalic()
			{
				Name = "materialTwo",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				},
				Blur = 0.1
			};

			_materialController.AddMaterial(_firstMaterial, _owner);
			_materialController.AddMaterial(_secondMaterial, _owner);

			Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient(_owner).Count);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void AddMaterial_SpacedMaterialName_FailTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = " spacedName ",
			};

		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void AddMaterial_EmptyMaterialName_FailTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = "",
			};
		}

		[TestMethod]
		public void ListMaterials_OkTest()
		{
			Material firstMaterial = new Lambertian()
			{
				Name = "materialOne",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};
			_materialController.AddMaterial(firstMaterial, _owner);

			Material secondMaterial = new Lambertian()
			{
				Name = "materialTwo",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};
			_materialController.AddMaterial(secondMaterial, _owner);

			Assert.AreEqual(2, _materialController.ListMaterials(_owner).Count);
		}

		[TestMethod]
		public void RemoveMaterials_OkTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			List<Model> models = new List<Model>();

			_materialController.AddMaterial(newMaterial, _owner);
			_materialController.RemoveMaterial(newMaterial.Name, _owner, models);

			List<Material> materials = _materialController.ListMaterials(_owner);
			Assert.IsFalse(materials.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundMaterialException))]
		public void RemoveMaterials_InvalidMaterialName_OkTest()
		{

			List<Model> models = new List<Model>();

			_materialController.RemoveMaterial("InvalidMaterialName", _owner, models);

			List<Material> materials = _materialController.ListMaterials(_owner);
			Assert.IsFalse(materials.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(MaterialUsedByModelException))]
		public void RemoveMaterial_MaterialUsedByModel_FailTest()
		{
			Material material = new Lambertian()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			Model model = new Model()
			{
				Name = "Test",
				Material = material,
				Figure = new Sphere(),
			};
			_materialController.AddMaterial(material, _owner);
			_modelController.AddModel(model, _owner);

			_materialController.RemoveMaterial("materialName", _owner, _modelController.ListModels(_owner));
		}

		[TestMethod]
		public void GetMaterial_ExistingMaterial_OkTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = "sphere",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			_materialController.AddMaterial(newMaterial, _owner);
			Material expected = _materialController.GetMaterial(_owner, newMaterial.Name);

			Assert.AreEqual(expected.Name, newMaterial.Name);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundMaterialException))]
		public void GetMaterial_ExistingMaterial_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			_materialController.GetMaterial(currentClient, "newFigure");
		}

		[TestMethod]
		public void ChangeLambertianName_OkTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = "materialName",
				Color = new Color
				{
					Red = 1,
					Green = 1,
					Blue = 1,
				}
			};

			_materialController.AddMaterial(newMaterial, _owner);

			_materialController.UpdateMaterialName(newMaterial, _owner, "newName");

			Material updatedMaterial = _materialController.ListMaterials(_owner)[0];

			Assert.AreEqual(updatedMaterial.Name, "newName");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidMaterialInputException))]
		public void ChangeLambertianName_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Material newMaterial = new Lambertian()
			{
				Name = "materialName",
			};

			_materialController.UpdateMaterialName(newMaterial, currentClient, " newNameMaterial ");
		}
	}
}
