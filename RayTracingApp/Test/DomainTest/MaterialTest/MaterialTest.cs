using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;

namespace Test.ModelsTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class MaterialTest
    {
        private Material _material;

        [TestMethod]

        public void CanCreateMaterial_OkTest()
        {
            _material = new Lambertian();
        }

        [TestMethod]
        public void SetOwner_Gomez_OkTest()
        {
            _material = new Lambertian()
            {
                Owner = "Gomez",
            };
            Assert.AreEqual("Gomez", _material.Owner);
        }

        [TestMethod]
        public void SetName_Brick_OkTest()
        {
            _material = new Lambertian()
            {
                Name = "Brick",
            };
            Assert.AreEqual("Brick", _material.Name);
        }

        [TestMethod]
        public void SetColor_validColor_OkTest()
        {
            Color _newColor = new Color();

            _material = new Lambertian()
            {
                Color = _newColor,
            };

            Assert.AreEqual(_newColor, _material.Color);
        }

        [TestMethod]
        public void SetType_OkTest()
        {
            MaterialEnum emptyEnum = new MaterialEnum();

            _material = new Lambertian()
            {
                Type = emptyEnum
            };

            Assert.AreEqual(emptyEnum, _material.Type);
        }

        [TestMethod]
        public void CanCreateMetallicMaterial_OkTest()
        {
            _material = new Metallic();
        }

        [TestMethod]
        public void SetBlur_ValidBlur_OkTest()
        {
            _material = new Metallic()
            {
                Blur = 0.1
            };
        }

    }
}
