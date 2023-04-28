using MemoryRepository;
using MemoryRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class FigureRepositoryTest
    {
        private FigureRepository _figureRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _figureRepository = new FigureRepository();
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

            Assert.AreEqual(newFigure, _figureRepository.GetFiguresByClient("OwnerName")[0]);
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

            CollectionAssert.Contains(iterable, newFigure);

        }

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

        public void RemoveFigure_NotExistingFigure_OkTest()
        {
            Figure newFigure = new Sphere()
            {
                Name = "Test",
                Owner = "OwnerName"
            };

            _figureRepository.RemoveFigure(newFigure);
            List<Figure> figures = _figureRepository.GetFiguresByClient("OwnerName");

            Assert.IsFalse(figures.Any());
        }
    }
}