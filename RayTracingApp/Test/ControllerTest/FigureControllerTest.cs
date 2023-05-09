using Controller;
using Controller.Exceptions;
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
	public class FigureControllerTest
	{
		private FigureController _figureController;

		[TestInitialize]
		public void TestInitialize()
		{
			_figureController = new FigureController();
		}

		[TestMethod]
		public void CreateFigureController_OkTest()
		{
			_figureController = new FigureController();
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

			CollectionAssert.Contains(iterable, newFigure);
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

			Assert.AreEqual(expected[0], _figureController.ListFigures(currentClient.Username)[0]);
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
				Owner = "ownerName",
				Name = "figureName",
				Radius = 10,
			};

			Model model = new Model()
			{
				Figure = figure,
				Owner = "ownerName"
			};
			ModelController modelController = new ModelController();
			modelController.Repository.AddModel(model);
			_figureController.AddFigure(figure, figure.Owner);

			_figureController.RemoveFigure("figureName", "ownerName", modelController.ListModels("ownerName"));
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

			Assert.AreEqual(expected, newFigure);
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
	}
}
