using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.Model
{
    [TestClass]
    public class FigureTest
    {
        private Figure _figure;
        private Sphere _sphere;
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
            _sphere = new Sphere();
        }
        [TestMethod]
        public void SetRadius_351_OkTest()
        {
            _sphere = new Sphere();
            _sphere.Radius = 3.51;
            Assert.AreEqual(3.51, _sphere.Radius);
        }
    }
}
