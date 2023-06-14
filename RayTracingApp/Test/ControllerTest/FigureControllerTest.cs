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
	public class FigureControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private FigureController _figureController;
		private ModelController _modelController;
		private ClientController _clientController;
		private Client _client;

		[TestInitialize]
		public void TestInitialize()
		{
			_figureController = new FigureController(TestDatabase);
			_modelController = new ModelController(TestDatabase);
			_clientController = new ClientController(TestDatabase);
			_client = new Client() { Username = "Owner123", Password = "Owner123" };
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext(TestDatabase))
			{
				context.ClearDBTable("Models");
				context.ClearDBTable("Figures");
				context.ClearDBTable("Clients");
			}
		}

		[TestMethod]
		public void CreateFigureController_OkTest()
		{
			_figureController = new FigureController(TestDatabase);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void NameIsNotEmpty_EmptyString_FailTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "",
				Owner = _client,
			};
			_figureController.AddFigure(newFigure, newFigure.Owner);
		}

		[TestMethod]
		public void NameIsNotEmpty_FigureName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "FigureName",
				Owner = _client,
				Radius = 10
			};
			_figureController.AddFigure(newFigure, newFigure.Owner);
		}

		[TestMethod]
		public void NameHasNoSpaces_MegaBall_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "MegaBall",
				Owner = _client,
				Radius = 10,
			};
			_figureController.AddFigure(newFigure, newFigure.Owner);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void NameHasNoSpaces_Figure_Name_FailTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Figure Name",
				Owner = _client,
				Radius = 10,
			};
			_figureController.AddFigure(newFigure, newFigure.Owner);
		}

		[TestMethod]
		public void FigureNameExist_FigureName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "figure",
				Owner = _client,
			};
			_figureController.Repository.AddFigure(newFigure, _client);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundFigureException))]
		public void FigureNameExist_NotExistingFigure_OkTest()
		{
			_figureController.GetFigure(_client, "figure");
		}

		[TestMethod]
		public void AddFigure_ValidName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "ValidName",
				Owner = _client,
				Radius = 10
			};

			_figureController.Repository.AddFigure(newFigure, _client);

		}

		[TestMethod]
		public void AddFigure_ValidFigure_OkTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			_figureController.AddFigure(newFigure, currentClient);
			List<Figure> iterable = _figureController.Repository.GetFiguresByClient(currentClient);

			Assert.AreEqual(iterable[0].Name, newFigure.Name);
			Assert.AreEqual(iterable[0].Owner.Id, newFigure.Owner.Id);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void AddFigure_InvalidFigure_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Figure newFigure = new Sphere()
			{
				Name = "invalid name",
				Radius = 10,
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void AddFigure_DuplicatedFigureName_FailTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			_figureController.AddFigure(newFigure, currentClient);
			_figureController.AddFigure(newFigure, currentClient);
		}

		[TestMethod]
		public void ListFigures_ValidClient_OkTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			_figureController.AddFigure(newFigure, currentClient);
			List<Figure> expected = _figureController.Repository.GetFiguresByClient(currentClient);

			Assert.AreEqual(expected[0].Name, _figureController.ListFigures(currentClient)[0].Name);
			Assert.AreEqual(expected[0].Owner.Id, _figureController.ListFigures(currentClient)[0].Owner.Id);
		}

		[TestMethod]
		public void ListFigures_NonExistentClient_FailTest()
		{
			_client.Username = "nonExistentUsername";
			List<Figure> figures = _figureController.ListFigures(_client);
			Assert.IsFalse(figures.Any());
		}

		[TestMethod]
		public void RemoveFigures_ValidFigure_FailTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			List<Model> models = new List<Model>();

			_figureController.AddFigure(newFigure, currentClient);
			_figureController.RemoveFigure(newFigure.Name, currentClient, models);

			List<Figure> figures = _figureController.ListFigures(currentClient);
			Assert.IsFalse(figures.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundFigureException))]
		public void RemoveFigures_InvalidFigureName_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			List<Model> models = new List<Model>();

			_figureController.RemoveFigure("InvalidFigureName", currentClient, models);

		}

		[TestMethod]
		[ExpectedException(typeof(FigureUsedByModelException))]
		public void RemoveFigures_FigureUsedByModel_FailTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure figure = new Sphere()
			{
				Name = "figureName",
				Radius = 10,
				Owner = currentClient,
			};

			Model model = new Model()
			{
				Name = "Test",
				Figure = figure,
				Material = new Lambertian(),
				Owner = currentClient
			};
			_figureController.AddFigure(figure, currentClient);
			_modelController.AddModel(model, currentClient);

			_figureController.RemoveFigure("figureName", currentClient, _modelController.ListModels(currentClient));
		}

		[TestMethod]
		public void FigureIsValid_ValidFigure_OkTest()
		{
			Figure newSphere = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
				Owner = _client
			};

			_figureController.AddFigure(newSphere, newSphere.Owner);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void FigureIsValid_InvalidFigure_FailTest()
		{
			Figure newSphere = new Sphere()
			{
				Name = "sphere",
				Radius = 0,
				Owner = _client
			};
			_figureController.AddFigure(newSphere, newSphere.Owner);
		}

		[TestMethod]
		public void GetFigure_ExistingClient_OkTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
				Owner = currentClient
			};

			_figureController.AddFigure(newFigure, currentClient);
			Figure expected = _figureController.GetFigure(currentClient, newFigure.Name);

			Assert.AreEqual(expected.Name, newFigure.Name);
			Assert.AreEqual(expected.Owner.Id, newFigure.Owner.Id);

		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundFigureException))]
		public void GetFigure_NonExistingFigure_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Figure expected = _figureController.GetFigure(currentClient, "newFigure");
		}

		[TestMethod]
		public void ChangeFigureName_OkTest()
		{
			_clientController.SignUp("Username123", "Password123");
			Client currentClient = _clientController.SignIn("Username123", "Password123");

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			_figureController.AddFigure(newFigure, currentClient);

			_figureController.UpdateFigureName(newFigure, currentClient, "newNameSphere");

			Figure updatedFigure = _figureController.ListFigures(currentClient)[0];

			Assert.AreEqual(updatedFigure.Name, "newNameSphere");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidFigureInputException))]
		public void ChangeFigureName_FailTest()
		{
			Client currentClient = new Client()
			{
				Username = "Username123",
				Password = "Password123"
			};

			Figure newFigure = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
			};

			_figureController.UpdateFigureName(newFigure, currentClient, "newNameSp here");
		}
	}
}
