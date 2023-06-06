using Controller;
using Controller.Exceptions;
using DBRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DBRepository;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class MaterialControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private MaterialController _materialController;
		private ModelController _modelController;

		[TestInitialize]
		public void TestInitialize()
		{
			_materialController = new MaterialController(TestDatabase);
			_modelController = new ModelController(TestDatabase);

		}


		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.AppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Models");
				context.ClearDBTable("Materials");
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
				}
			};

			_materialController.AddMaterial(_newMaterial, "user");

			Assert.AreEqual(_materialController.Repository.GetMaterialsByClient("user")[0].Name, _newMaterial.Name);
		}

        [TestMethod]
        public void AddMaterial_ValidMetallic_OkTest()
        {
            Material _newMaterial = new Metallic()
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

            _materialController.AddMaterial(_newMaterial, "user");

            Assert.AreEqual(_materialController.Repository.GetMaterialsByClient("user")[0].Name, _newMaterial.Name);
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

			_materialController.AddMaterial(_newMaterial, "user");
			_materialController.AddMaterial(_newMaterial, "user");
		}

        [TestMethod]
        [ExpectedException(typeof(InvalidMaterialInputException))]
        public void AddMaterial_DuplicatedMetallic_FailTest()
        {
            Material _newMaterial = new Metallic()
            {
                Name = "materialName",
                Color = new Color
                {
                    Red = 1,
                    Green = 1,
                    Blue = 1,
                },
				Blur= 0.1
            };

            _materialController.AddMaterial(_newMaterial, "user");
            _materialController.AddMaterial(_newMaterial, "user");
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

			_materialController.AddMaterial(_firstMaterial, "user");
			_materialController.AddMaterial(_secondMaterial, "user");

			Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient("user").Count);
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
			_materialController.AddMaterial(firstMaterial, "username");

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
			_materialController.AddMaterial(secondMaterial, "username");

			Assert.AreEqual(2, _materialController.ListMaterials("username").Count);
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

			_materialController.AddMaterial(newMaterial, "username");
			_materialController.RemoveMaterial(newMaterial.Name, "username", models);

			List<Material> materials = _materialController.ListMaterials("username");
			Assert.IsFalse(materials.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundMaterialException))]
		public void RemoveMaterials_InvalidMaterialName_OkTest()
		{

			List<Model> models = new List<Model>();

			_materialController.RemoveMaterial("InvalidMaterialName", "username", models);

			List<Material> materials = _materialController.ListMaterials("username");
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
			_materialController.AddMaterial(material, "Owner");
			_modelController.AddModel(model, "Owner");

			_materialController.RemoveMaterial("materialName", "Owner", _modelController.ListModels("Owner"));
		}

		[TestMethod]
		public void GetMaterial_ExistingMaterial_OkTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

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

			_materialController.AddMaterial(newMaterial, currentClient.Username);
			Material expected = _materialController.GetMaterial(currentClient.Username, newMaterial.Name);

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

			_materialController.GetMaterial("newFigure", currentClient.Username);
		}

		[TestMethod]
		public void ChangeLambertianName_OkTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

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

			_materialController.AddMaterial(newMaterial, currentClient.Username);

			_materialController.UpdateMaterialName(newMaterial, currentClient.Username, "newName");

			Material updatedMaterial = _materialController.ListMaterials(currentClient.Username)[0];

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

			_materialController.UpdateMaterialName(newMaterial, currentClient.Username, " newNameMaterial ");
		}
	}
}
