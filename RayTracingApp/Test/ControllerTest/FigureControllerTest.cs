using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

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
    }
}
