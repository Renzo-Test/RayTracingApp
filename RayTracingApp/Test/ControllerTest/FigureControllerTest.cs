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
        public void CheckNameIsNotEmpty_EmptyString_OkTest()
        {
            bool result = _figureController.CheckNameIsNotEmpty("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckNameIsNotEmpty_FigureName_OkTest()
        {
            bool result = _figureController.CheckNameIsNotEmpty("FigureName");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckNameHasNoSpaces_EmptyString_OkTest()
        {
            bool result = _figureController.CheckNameHasNoSpaces("");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckNameHasNoSpaces_FigureName_OkTest()
        {
            bool result = _figureController.CheckNameHasNoSpaces("FigureName");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckNameHasNoSpaces_Figure_Name_OkTest()
        {
            bool result = _figureController.CheckNameHasNoSpaces("Figure Name");
            Assert.IsFalse(result);
        }
    }
}
