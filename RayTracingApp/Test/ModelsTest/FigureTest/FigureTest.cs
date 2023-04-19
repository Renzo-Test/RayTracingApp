using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Test.ModelsTest
{
    [TestClass]
    public class FigureTest
    {
        private Figure _figure;
        private Sphere _sphere;

        [TestMethod]
        public void CanCreateFigure_OkTest()
        {
            _figure = new Sphere();
        }

        [TestMethod]
        public void SetName_Dragon_Balloon_OkTest()
        {
            _figure = new Sphere()
            {
                Name = "Dragon Balloon",
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
            _sphere = new Sphere()
            {
                Radius = 3.51,
            };
            Assert.AreEqual(3.51, _sphere.Radius);
        }

        [TestMethod]
        public void CanCreateSphere_Balloon_351_OkTest()
        {
            _sphere = new Sphere()
            {
                Name = "Balloon",
                Radius = 3.51
            };
            Assert.AreEqual(3.51, _sphere.Radius);
            Assert.AreEqual("Balloon", _sphere.Name);
        }

        [TestMethod]
        public void SetNameAndOwner_OkTest()
        {
            _figure = new Sphere()
            {
                Name = "Figure name",
                Owner = "Owner name"
            };
            Assert.AreEqual(_figure.Name, "Figure name");
            Assert.AreEqual(_figure.Owner, "Owner name");
        }
    }
}
