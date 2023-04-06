using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
