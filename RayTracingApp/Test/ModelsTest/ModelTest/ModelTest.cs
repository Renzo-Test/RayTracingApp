using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;

namespace Test.ModelsTest
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        public void CreateModels_OkTest()
        {
            Model newModel= new Model();
        }

        [TestMethod]
        public void SetOwner_OkTest()
        {
            Model newModel = new Model()
            {
                Owner = "ownerName"
            };
            Assert.AreEqual("ownerName", newModel.Owner);
        }

        [TestMethod]
        public void SetName_OkTest()
        {
            Model newModel = new Model()
            {
                Name = "modelName"
            };
            Assert.AreEqual("modelName", newModel.Name);
        }

        [TestMethod]
        public void SetFigure_OkTest()
        {
            Figure newFigure = new Sphere()
            {
                Name = "figureName",
                Owner = "ownerName"
            };

            Model newModel = new Model()
            {
                Figure = newFigure
            };
            Assert.AreEqual(newFigure, newModel.Figure);
        }

        [TestMethod]
        public void SetMaterial_OkTest()
        {
            Material newMaterial = new LambertianMaterial()
            {
                Name = "materialName"
            };

            Model newModel = new Model()
            {
                Material = newMaterial
            };
            Assert.AreEqual(newMaterial, newModel.Material);
        }
    }
}
