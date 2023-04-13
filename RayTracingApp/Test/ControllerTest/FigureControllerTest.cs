using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using System.Collections.Generic;

namespace Test.ControllerTest
{
    [TestClass]
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
        public void NameIsNotEmpty_EmptyString_OkTest()
        {
            bool result = _figureController.NameIsNotEmpty("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NameIsNotEmpty_FigureName_OkTest()
        {
            bool result = _figureController.NameIsNotEmpty("FigureName");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameHasNoSpaces_EmptyString_OkTest()
        {
            bool result = _figureController.NameHasNoSpaces("");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameHasNoSpaces_FigureName_OkTest()
        {
            bool result = _figureController.NameHasNoSpaces("FigureName");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameHasNoSpaces_Figure_Name_OkTest()
        {
            bool result = _figureController.NameHasNoSpaces("Figure Name");
            Assert.IsFalse(result);
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

            bool result = _figureController.FigureNameExist("figure", "owner");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FigureNameExist_NotExistingFigure_OkTest()
        {
            bool result = _figureController.FigureNameExist("figure", "owner");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FigureNameIsValid_ValidName_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Name = "ValidName",
                Owner = "OwnerName"
            };
            _figureController.Repository.AddFigure(newFigure);

            bool result = _figureController.FigureNameIsValid(newFigure.Name, newFigure.Owner);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddFigure_ValidFigure_OkTest()
        {

            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure newFigure = new Figure()
            {
                Name = "figure",
            };

            _figureController.AddFigure(newFigure, currentClient.Username);
            List<Figure> iterable = _figureController.Repository.GetFiguresByClient(currentClient.Username);

            CollectionAssert.Contains(iterable, newFigure);
        }

        [TestMethod]
        public void AddFigure_InvalidFigure_OkTest()
        {

            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure newFigure = new Figure()
            {
                Name = "invalid name",
            };

            _figureController.AddFigure(newFigure, currentClient.Username);
            List<Figure> iterable = _figureController.Repository.GetFiguresByClient(currentClient.Username);

            CollectionAssert.DoesNotContain(iterable, newFigure);
        }

        [TestMethod]
        public void AddFigure_DuplicatedFigureName_OkTest()
        {

            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            Figure firstFigure = new Figure()
            {
                Name = "figureOne",
            };

            _figureController.AddFigure(firstFigure, currentClient.Username);
            _figureController.AddFigure(firstFigure, currentClient.Username);
            List<Figure> clientFigures = _figureController.Repository.GetFiguresByClient(currentClient.Username);

            Assert.AreEqual(1, clientFigures.Count);
        }
    }
}
