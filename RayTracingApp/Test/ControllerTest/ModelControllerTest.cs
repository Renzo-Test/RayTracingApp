using Controller;
using DBRepository.Exceptions;
using Domain;
using Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ModelControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private ModelController _modelController;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void Testinitialize()
		{
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
				context.ClearDBTable("Clients");
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
				Material = new Lambertian()
			};
			_modelController.AddModel(targetModel, _owner);

			Model anotherModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			_modelController.AddModel(anotherModel, _otherOwner);

			List<Model> expected = _modelController.ListModels(_owner);
			Assert.AreEqual(expected[0].Id, targetModel.Id);
			Assert.AreEqual(1, expected.Count());
		}

		[TestMethod]
		public void ListModels_InvalidUsername_OkTest()
		{
			List<Model> models = _modelController.ListModels(_owner);
			Assert.IsFalse(models.Any());
		}

		[TestMethod]
		public void AddModel_ValidModel_OkTest()
		{
			Model _newModel = new Model()
			{
				Name = "Test",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			_modelController.AddModel(_newModel, _owner);

			List<Model> expected = _modelController.Repository.GetModelsByClient(_owner);
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
				Material = new Lambertian()
			};
			_modelController.AddModel(_newModel, _owner);
			_modelController.AddModel(_newModel, _owner);
		}

		[TestMethod]
		public void AddModel_TwoValidModels_OkTest()
		{
			Model _fstNewModel = new Model()
			{
				Name = "Test one",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			Model _sndNewModel = new Model()
			{
				Name = "Test two",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			_modelController.AddModel(_fstNewModel, _owner);
			_modelController.AddModel(_sndNewModel, _owner);
			Assert.AreEqual(2, _modelController.Repository.GetModelsByClient(_owner).Count);
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
				Material = new Lambertian()
			};
			_modelController.AddModel(firstModel, _owner);

			Model secondModel = new Model()
			{
				Name = "modelTwo",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			_modelController.AddModel(secondModel, _owner);
			Assert.AreEqual(2, _modelController.ListModels(_owner).Count);
		}

		[TestMethod]
		public void RemoveModels_OkTest()
		{
			Model newModel = new Model()
			{
				Name = "modelName",
				Figure = new Sphere(),
				Material = new Lambertian()
			};
			_modelController.AddModel(newModel, _owner);
			_modelController.RemoveModel(newModel.Name, _owner);

			List<Model> models = _modelController.ListModels(_owner);
			Assert.IsFalse(models.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundModelException))]
		public void RemoveModels_InvalidModelName_FailTest()
		{
			_modelController.RemoveModel("InvaledModelName", _otherOwner);
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
				Material = new Lambertian()
			};

			_modelController.AddModel(newModel, currentClient);
			Model expected = _modelController.GetModel(currentClient, newModel.Name);

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

			_modelController.GetModel(currentClient, "newModel");
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
				Material = new Lambertian()
			};

			_modelController.AddModel(newModel, currentClient);
			_modelController.UpdateModelName(newModel, currentClient, "newName");

			Model expected = _modelController.GetModel(currentClient, "newName");
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
				Material = new Lambertian()
			};

			_modelController.UpdateModelName(newModel, currentClient, " newName ");
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
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
				Material = new Lambertian()
			};

			Bitmap img = new Bitmap(600, 300);
			_modelController.AddModel(newModel, currentClient);

			_modelController.UpdatePreview(newModel, img);

			Model updatedScene = _modelController.ListModels(currentClient)[0];

			Assert.AreEqual(img.ToString(), updatedScene.GetPreview().ToString());
		}

	}
}
