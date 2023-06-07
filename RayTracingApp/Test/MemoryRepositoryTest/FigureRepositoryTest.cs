using DBRepository;
using DBRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System;

namespace Test.MemoryRepositoryTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class FigureRepositoryTest
	{
		private FigureRepository _figureRepository;

		[TestInitialize]
		public void TestInitialize()
		{
			_figureRepository = new FigureRepository()
			{
				DBName = "RayTracingAppTestDB"
			};
		}

		[TestCleanup]
		public void TestCleanUp()
        {
			using (var context = new DBRepository.AppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Figures");
			}
		}

		[TestMethod]	
		public void CreateFigureRepository_OkTest()
		{
			_figureRepository = new FigureRepository();
		}

		[TestMethod]
		public void GetFiguresByClient_OwnerName_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = "OwnerName"
			};
			_figureRepository.AddFigure(newFigure);

			Assert.AreEqual(newFigure.Name, _figureRepository.GetFiguresByClient("OwnerName")[0].Name);
			Assert.AreEqual(newFigure.Owner, _figureRepository.GetFiguresByClient("OwnerName")[0].Owner);

		}

		[TestMethod]
		public void GetFiguresByClient_TwoClients_OkTest()
		{
			Figure firstFigure = new Sphere()
			{
				Name = "FigureOne",
				Owner = "OwnerOne"
			};
			_figureRepository.AddFigure(firstFigure);

			Figure secondFigure = new Sphere()
			{
				Name = "FigureTwo",
				Owner = "OwnerTwo"
			};
			_figureRepository.AddFigure(secondFigure);

			Assert.AreEqual("FigureOne", _figureRepository.GetFiguresByClient("OwnerOne")[0].Name);
			Assert.AreEqual("FigureTwo", _figureRepository.GetFiguresByClient("OwnerTwo")[0].Name);
		}

		[TestMethod]
		public void GetFiguresByClient_NotExisting2Client()
		{
			_figureRepository.GetFiguresByClient("");
		}

		[TestMethod]
		public void AddFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = "OwnerName"
			};

			_figureRepository.AddFigure(newFigure);

			List<Figure> iterable = _figureRepository.GetFiguresByClient("OwnerName");

			Assert.AreEqual(newFigure.Name, iterable[0].Name);
			Assert.AreEqual(newFigure.Owner, iterable[0].Owner);
		}

		[TestMethod]
		public void RemoveFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = "OwnerName"
			};

			_figureRepository.AddFigure(newFigure);
			_figureRepository.RemoveFigure(newFigure);
			List<Figure> figures = _figureRepository.GetFiguresByClient("OwnerName");

			Assert.IsFalse(figures.Any());
		}

		[TestMethod]
        [ExpectedException(typeof(NotFoundFigureException))]
        public void RemoveFigure_NotExistingFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = "OwnerName"
			};

			_figureRepository.RemoveFigure(newFigure);
		}
	}
}