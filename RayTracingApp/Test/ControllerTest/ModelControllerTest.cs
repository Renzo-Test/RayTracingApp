using Controller;
using MemoryRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ModelControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private ModelController _modelController;

		[TestInitialize]
		public void Testinitialize()
		{
			_modelController = new ModelController(TestDatabase);
		}

		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.AppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Models");
			}
		}

		[TestMethod]
		public void CreateModelController_OkTest()
		{
			_modelController = new ModelController(TestDatabase);
		}

		[TestMethod]
		public void ListModels_ValidUsername_OkTest()
		{
			Model targetModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(targetModel, "Owner");

			Model anotherModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(anotherModel, "OtherOwner");
			
			List<Model> expected = _modelController.ListModels("Owner");
			Assert.AreEqual(expected[0].Id, targetModel.Id);
			Assert.AreEqual(1, expected.Count());
		}

		[TestMethod]
		public void ListModels_InvalidUsername_OkTest()
		{
			List<Model> models = _modelController.ListModels("owner");
			Assert.IsFalse(models.Any());
		}

		[TestMethod]
		public void AddModel_ValidModel_OkTest()
		{
			Model _newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(_newModel, "OwnerName");

			List<Model> expected = _modelController.Repository.GetModelsByClient("OwnerName");
			Assert.AreEqual(expected[0].Id, _newModel.Id);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidModelInputException))]
		public void AddModel_DuplicatedModel_FailTest()
		{
			Model _newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(_newModel, "user");
			_modelController.AddModel(_newModel, "user");
		}

		[TestMethod]
		public void AddModel_TwoValidModels_OkTest()
		{
			Model _fstNewModel = new Model()
			{
				Name = "Test one",
				Figure = new Sphere(),
				Material = new Material()
			};
			Model _sndNewModel = new Model()
			{
				Name = "Test two",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(_fstNewModel, "user");
			_modelController.AddModel(_sndNewModel, "user");
			Assert.AreEqual(2, _modelController.Repository.GetModelsByClient("user").Count);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidModelInputException))]
		public void AddModel_SpacedModelName_FailTest()
		{
			Model _newModel = new Model()
			{
				Name = "  spacedName"
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidModelInputException))]
		public void AddModel_EmptyModelName_FailTest()
		{
			Model _newModel = new Model()
			{
				Name = "",
			};
		}

		[TestMethod]
		public void ListModels_OkTest()
		{
			Model firstModel = new Model()
			{
				Name = "modelOne",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(firstModel, "username");

			Model secondModel = new Model()
			{
				Name = "modelTwo",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(secondModel, "username");
			Assert.AreEqual(2, _modelController.ListModels("username").Count);
		}

		[TestMethod]
		public void RemoveModels_OkTest()
		{
			Model newModel = new Model()
			{
				Name = "modelName",
				Figure = new Sphere(),
				Material = new Material()
			};
			_modelController.AddModel(newModel, "username");
			_modelController.RemoveModel(newModel.Name, "username");

			List<Model> models = _modelController.ListModels("username");
			Assert.IsFalse(models.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundModelException))]
		public void RemoveModels_InvalidModelName_FailTest()
		{
			_modelController.RemoveModel("InvaledModelName", "username");
		}

		[TestMethod]
		public void GetModel_ExistingClient_OkTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Model newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};

			_modelController.AddModel(newModel, currentClient.Username);
			Model expected = _modelController.GetModel(currentClient.Username, newModel.Name);

			Assert.AreEqual(expected.Id, newModel.Id);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundModelException))]
		public void GetModel_ExistingClientNonExistingName_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			_modelController.GetModel(currentClient.Username, "newModel");
		}

		[TestMethod]
		public void ChangeModelName_OkTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Model newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};

			_modelController.AddModel(newModel, currentClient.Username);
			_modelController.UpdateModelName(newModel, currentClient.Username, "newName");

			Model expected = _modelController.GetModel(currentClient.Username, "newName");
			Assert.AreEqual(expected.Name, "newName");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidModelInputException))]
		public void ChangeModelName_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Model newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Material()
			};

			_modelController.UpdateModelName(newModel, currentClient.Username, " newName ");
		}
	}
}
