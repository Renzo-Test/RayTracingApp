using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.Model
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void CanCreateFigure_OkTest()
        {
            Figure figure = new Figure();
        }
    }
}
