﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using Model;
using System.Collections;

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


        /*
        [TestMethod]
        public void AddFigure_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test"
            };

            _figureRepository.AddFigure(newFigure);

            ICollection iterable = (ICollection)_figureRepository.GetFigures();
            CollectionAssert.Contains(iterable, newFigure);
            
        }

        [TestMethod]
        public void RemoveFigure_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test"
            };

            _figureRepository.AddFigure(newFigure);
            _figureRepository.RemoveFigure(newFigure);
            ICollection iterable = (ICollection)_figureRepository.GetFigures();
            CollectionAssert.DoesNotContain(iterable, newFigure);

        }

        [TestMethod]
        public void RemoveFigure_NotExistingFigure_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test"
            };

            _figureRepository.RemoveFigure(newFigure);
            ICollection iterable = (ICollection)_figureRepository.GetFigures();
            CollectionAssert.DoesNotContain(iterable, newFigure);

        }

        [TestMethod]
        public void GetFigures_ExistingFigures_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "Test"
            };
            Figure secondNewFigure = new Figure()
            {
                Name = "SecondTest"
            };
            
            _figureRepository.AddFigure(newFigure);
            _figureRepository.AddFigure(secondNewFigure);
           
            ICollection iterable = (ICollection)_figureRepository.GetFigures();
           
            CollectionAssert.Contains(iterable, newFigure);
            CollectionAssert.Contains(iterable, secondNewFigure);

        }
        */


    }
}