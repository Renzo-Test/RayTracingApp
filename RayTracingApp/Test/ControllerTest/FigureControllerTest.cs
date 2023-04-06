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

        [TestMethod]
        public void CreateFigureController_OkTest()
        {
            _figureController = new FigureController();
        }

        [TestMethod]
        public void CheckNameIsNotEmpty_EmptyString_OkTest()
        {
            _figureController = new FigureController();
            bool result = _figureController.CheckNameIsNotEmpty("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckNameIsNotEmpty_FigureName_OkTest()
        {
            _figureController = new FigureController();
            bool result = _figureController.CheckNameIsNotEmpty("FigureName");
            Assert.IsTrue(result);
        }
    }
}
