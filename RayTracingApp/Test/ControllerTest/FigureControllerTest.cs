using Controller;
using Controller.Exceptions;
using DBRepository.Exceptions;
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
	public class FigureControllerTest
	{
        private const string TestDatabase = "RayTracingAppTestDB";
        private FigureController _figureController;
		private ModelController _modelController;

		[TestInitialize]
		public void TestInitialize()
		{
			_figureController = new FigureController(TestDatabase);
			_modelController = new ModelController(TestDatabase);
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.AppContext(TestDatabase))
			{
				context.ClearDBTable("Models");
				context.ClearDBTable("Figures");
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
				Owner = "Owner123",
			};
			_figureController.AddFigure(newFigure, newFigure.Owner);
		}

		[TestMethod]
		public void NameIsNotEmpty_FigureName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "FigureName",
				Owner = "Owner123",
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
				Owner = "Owner123",
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
				Owner = "Owner123",
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
				Owner = "owner",
			};
			_figureController.Repository.AddFigure(newFigure);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundFigureException))]
		public void FigureNameExist_NotExistingFigure_OkTest()
		{
			_figureController.GetFigure("Username123", "figure");
		}

		[TestMethod]
		public void AddFigure_ValidName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "ValidName",
				Owner = "OwnerName",
				Radius = 10
			};

			_figureController.Repository.AddFigure(newFigure);

		}

		[TestMethod]
		public void AddFigure_ValidFigure_OkTest()
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

			_figureController.AddFigure(newFigure, currentClient.Username);
			List<Figure> iterable = _figureController.Repository.GetFiguresByClient(currentClient.Username);

			Assert.AreEqual(iterable[0].Name, newFigure.Name);
			Assert.AreEqual(iterable[0].Owner, newFigure.Owner);
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

			_figureController.AddFigure(newFigure, currentClient.Username);
			_figureController.AddFigure(newFigure, currentClient.Username);
		}

		[TestMethod]
		public void ListFigures_ValidClient_OkTest()
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

			_figureController.AddFigure(newFigure, currentClient.Username);
			List<Figure> expected = _figureController.Repository.GetFiguresByClient(currentClient.Username);

			Assert.AreEqual(expected[0].Name, _figureController.ListFigures(currentClient.Username)[0].Name);
			Assert.AreEqual(expected[0].Owner, _figureController.ListFigures(currentClient.Username)[0].Owner);
		}

		[TestMethod]
		public void ListFigures_NonExistentClient_FailTest()
		{
			List<Figure> figures = _figureController.ListFigures("nonExistentUsername");
			Assert.IsFalse(figures.Any());
		}

		[TestMethod]
		public void RemoveFigures_ValidFigure_FailTest()
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

			List<Model> models = new List<Model>();

			_figureController.AddFigure(newFigure, currentClient.Username);
			_figureController.RemoveFigure(newFigure.Name, currentClient.Username, models);

			List<Figure> figures = _figureController.ListFigures(currentClient.Username);
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

			_figureController.RemoveFigure("InvalidFigureName", currentClient.Username, models);

		}

		[TestMethod]
		[ExpectedException(typeof(FigureUsedByModelException))]
		public void RemoveFigures_FigureUsedByModel_FailTest()
		{
			Figure figure = new Sphere()
			{
				Name = "figureName",
				Radius = 10,
			};

			Model model = new Model()
			{
				Name = "Test",
				Figure = figure,
				Material = new Material(),
			};
			_figureController.AddFigure(figure, "Owner");
			_modelController.AddModel(model, "Owner");

			_figureController.RemoveFigure("figureName", "Owner", _modelController.ListModels("Owner"));
		}

		[TestMethod]
		public void FigureIsValid_ValidFigure_OkTest()
		{
			Figure newSphere = new Sphere()
			{
				Name = "sphere",
				Radius = 10,
				Owner = "Username123"
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
				Owner = "Username123"
			};
			_figureController.AddFigure(newSphere, newSphere.Owner);
		}

		[TestMethod]
		public void GetFigure_ExistingClient_OkTest()
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

			_figureController.AddFigure(newFigure, currentClient.Username);
			Figure expected = _figureController.GetFigure(currentClient.Username, newFigure.Name);

			Assert.AreEqual(expected.Name, newFigure.Name);
			Assert.AreEqual(expected.Owner, newFigure.Owner);

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

			Figure expected = _figureController.GetFigure(currentClient.Username, "newFigure");
		}

		[TestMethod]
		public void ChangeFigureName_OkTest()
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

			_figureController.AddFigure(newFigure, currentClient.Username);

			_figureController.UpdateFigureName(newFigure, currentClient.Username, "newNameSphere");

			Figure updatedFigure = _figureController.ListFigures(currentClient.Username)[0];

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

			_figureController.UpdateFigureName(newFigure, currentClient.Username, "newNameSp here");
		}
	}
}
