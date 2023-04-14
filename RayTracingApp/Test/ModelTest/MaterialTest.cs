using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.ModelTest
{
    [TestClass]

    public class Class1
    {
        private Material _material;

        [TestMethod]
        public void CanCreateMaterial_OkTest()
        {
            _material = new LambertianMaterial();
        }

        [TestMethod]
        public void SetOwner_Gomez_OkTest()
        {
            _material = new LambertianMaterial()
            {
                Owner = "Gomez",
            };
            Assert.AreEqual("Gomez", _material.Owner);
        }

        [TestMethod]
        public void SetName_Brick_OkTest()
        {
            _material = new LambertianMaterial()
            {
                Name = "Brick",
            };
            Assert.AreEqual("Brick", _material.Name);
        }

        [TestMethod]
        public void SetColor_validColor_OkTest()
        {
            Color _newColor = new Color();
            
            _material = new LambertianMaterial()
            {
                Color = _newColor,
            };

            Assert.AreEqual(_newColor, _material.Color);
        }

    }
}
