using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.Model
{
    [TestClass]
    public class FigureTest
    {
        private Figure _figure;
        [TestMethod]
        public void CanCreateFigure_OkTest()
        {
            _figure = new Figure();
        }
        [TestMethod]
        public void SetName_Dragon_Balloon_OkTest()
        {
            _figure = new Figure()
            {
                Name = "Dragon Balloon"
            };
            Assert.AreEqual("Dragon Balloon", _figure.Name);
        }
        [TestMethod]
        public void CanCreateSphere_OkTest()
        {
            Sphere sphere = new Sphere();
        }
    }
}
