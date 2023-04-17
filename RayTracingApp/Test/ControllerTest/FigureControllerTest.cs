using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections.Generic;
using MemoryRepository.Exceptions;
using Controller.FigureExceptions;
using Controller.SphereExceptions;

namespace Test.ControllerTest
{
    [TestClass]
    public class FigureControllerTest
    {
        private FigureController _figureController;

        [TestInitialize]
        public void TestInitialize()
        {
            _figureController = new SphereController();
        }

        [TestMethod]
        public void CreateFigureController_OkTest()
        {
            _figureController = new SphereController();
        }

        [ExpectedException(typeof(NotInExpectedRangeException))]
        [TestMethod]
        public void NameIsNotEmpty_EmptyString_OkTest()
        {
            _figureController.RunEmptyNameChecker("");
        }

        [TestMethod]
        public void NameIsNotEmpty_FigureName_OkTest()
        {
            _figureController.RunEmptyNameChecker("FigureName");
        }

        [TestMethod]
        public void NameHasNoSpaces_EmptyString_OkTest()
        {
            _figureController.RunSpacedNameChecker("");
        }

        [TestMethod]
        public void NameHasNoSpaces_FigureName_OkTest()
        {
            _figureController.RunSpacedNameChecker("FigureName");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void NameHasNoSpaces_Figure_Name_OkTest()
        {
            _figureController.RunSpacedNameChecker("Figure Name");
        }

        [TestMethod]
        public void FigureNameExist_FigureName_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "figure",
                Owner = "owner",
            };
            _figureController.Repository.AddFigure(newFigure);

            _figureController.FigureNameExist("figure", "owner");
        }

        [TestMethod]
        public void FigureNameExist_NotExistingFigure_OkTest()
        {
            bool result = _figureController.FigureNameExist("figure", "owner");
            Assert.IsFalse(result);
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
                Username = "user",
                Password = "pass"
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

        [ExpectedException(typeof(InvalidFigureInputException))]
        [TestMethod]
        public void AddFigure_InvalidFigure_OkTest()
        {
            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure newFigure = new Sphere()
            {
                Name = "invalid name",
                Radius = 10,
            };

            _figureController.AddFigure(newFigure, currentClient.Username);
            _figureController.Repository.GetFiguresByClient(currentClient.Username);
        }

        [ExpectedException(typeof(InvalidFigureInputException))]
        [TestMethod]
        public void AddFigure_DuplicatedFigureName_OkTest()
        {
            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure newFigure = new Sphere()
            {
                Name = "sphere",
                Radius = 10,
            };

            _figureController.AddFigure(newFigure, currentClient.Username);
            _figureController.AddFigure(newFigure, currentClient.Username);
            List<Figure> clientFigures = _figureController.Repository.GetFiguresByClient(currentClient.Username);
        }

        [TestMethod]
        public void ListFigures_ValidClient_OkTest()
        {
            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
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

        [ExpectedException(typeof(NotFoundFigureException))]
        [TestMethod]
        public void ListFigures_NonExistentClient_OkTest()
        {
            _figureController.ListFigures("nonExistentUsername");
        }

        [ExpectedException(typeof(NotFoundFigureException))]
        [TestMethod]
        public void DeleteFigures_ValidFigure_OkTest()
        {
            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure newFigure = new Sphere()
            {
                Name = "sphere",
                Radius = 10,
            };

            _figureController.AddFigure(newFigure, currentClient.Username);
            _figureController.RemoveFigure(newFigure.Name, currentClient.Username);

            _figureController.ListFigures(currentClient.Username);
        }

        [TestMethod]
        public void FigureIsValid_ValidFigure_OkTest()
        {
            Figure newSphere = new Sphere()
            {
                Name = "sphere",
                Radius = 10,
            };

            _figureController.RunFigurePropertiesChecker(newSphere);
        }
        
        [ExpectedException(typeof(SmallerThanCeroRadiusException))]
        [TestMethod]
        public void FigureIsValid_InvalidFigure_OkTest()
        {
            Figure newSphere = new Sphere()
            {
                Name = "sphere",
                Radius = 0,
            };

            _figureController.RunFigurePropertiesChecker(newSphere);
        }
    }
}
