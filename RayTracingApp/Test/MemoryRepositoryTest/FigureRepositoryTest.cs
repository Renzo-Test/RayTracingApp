using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using Models;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

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
            Figure newFigure = new Figure()
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
            Figure firstFigure = new Figure()
            {
                Name = "FigureOne",
                Owner = "OwnerOne"
            };
            _figureRepository.AddFigure(firstFigure);

            Figure secondFigure = new Figure()
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
            Figure newFigure = new Figure()
            {
                Name = "Test",
                Owner = "OwnerName"
            };

            _figureRepository.AddFigure(newFigure);

            List<Figure> iterable = _figureRepository.GetFiguresByClient("OwnerName");

            CollectionAssert.Contains(iterable, newFigure);
            
        }

        [TestMethod]
        public void RemoveFigure_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test",
                Owner = "OwnerName"
            };

            _figureRepository.AddFigure(newFigure);
            _figureRepository.RemoveFigure(newFigure);
            List<Figure> iterable = _figureRepository.GetFiguresByClient("OwnerName");

            CollectionAssert.DoesNotContain(iterable, newFigure);

        }

        [TestMethod]
        public void RemoveFigure_NotExistingFigure_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test",
                Owner = "OwnerName"
            };

            _figureRepository.RemoveFigure(newFigure);
            List<Figure> iterable = _figureRepository.GetFiguresByClient("OwnerName");

            CollectionAssert.DoesNotContain(iterable, newFigure);

        }
    }
}