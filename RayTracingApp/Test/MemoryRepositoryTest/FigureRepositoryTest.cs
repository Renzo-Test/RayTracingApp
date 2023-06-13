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
	public class FigureRepositoryTest
	{
		private FigureRepository _figureRepository;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
			_figureRepository = new FigureRepository()
			{
				DBName = "RayTracingAppTestDB"
			};

			_owner = new Client() { Username = "ownerName" };
			_otherOwner = new Client() { Username = "otherName" };
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
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
				Owner = _owner
			};
			_figureRepository.AddFigure(newFigure, _owner);

			Assert.AreEqual(newFigure.Name, _figureRepository.GetFiguresByClient(_owner)[0].Name);
			Assert.AreEqual(newFigure.Owner, _figureRepository.GetFiguresByClient(_owner)[0].Owner);

		}

		[TestMethod]
		public void GetFiguresByClient_TwoClients_OkTest()
		{
			Figure firstFigure = new Sphere()
			{
				Name = "FigureOne",
				Owner = _owner
			};
			_figureRepository.AddFigure(firstFigure, _owner);

			Figure secondFigure = new Sphere()
			{
				Name = "FigureTwo",
				Owner = _otherOwner
			};
			_figureRepository.AddFigure(secondFigure, _otherOwner);

			Assert.AreEqual("FigureOne", _figureRepository.GetFiguresByClient(_owner)[0].Name);
			Assert.AreEqual("FigureTwo", _figureRepository.GetFiguresByClient(_otherOwner)[0].Name);
		}

		[TestMethod]
		public void GetFiguresByClient_NotExisting2Client()
		{
			Client notExitingClient = new Client() { Username = "notExist" };

			_figureRepository.GetFiguresByClient(notExitingClient);
		}

		[TestMethod]
		public void AddFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = _owner
			};

			_figureRepository.AddFigure(newFigure, _owner);

			List<Figure> iterable = _figureRepository.GetFiguresByClient(_owner);

			Assert.AreEqual(newFigure.Name, iterable[0].Name);
			Assert.AreEqual(newFigure.Owner, iterable[0].Owner);
		}

		[TestMethod]
		public void RemoveFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = _owner
			};

			_figureRepository.AddFigure(newFigure, _owner);
			_figureRepository.RemoveFigure(newFigure);
			List<Figure> figures = _figureRepository.GetFiguresByClient(_owner);

			Assert.IsFalse(figures.Any());
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundFigureException))]
		public void RemoveFigure_NotExistingFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "Test",
				Owner = _owner
			};

			_figureRepository.RemoveFigure(newFigure);
		}
	}
}