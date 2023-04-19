using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Test.ModelsTest
{
    [TestClass]

    public class MaterialTest
    {
        private Material _material;

        [TestMethod]
        public void CanCreateMaterial_OkTest()
        {
            _material = new Material();
        }

        [TestMethod]
        public void SetOwner_Gomez_OkTest()
        {
            _material = new Material()
            {
                Owner = "Gomez",
            };
            Assert.AreEqual("Gomez", _material.Owner);
        }

        [TestMethod]
        public void SetName_Brick_OkTest()
        {
            _material = new Material()
            {
                Name = "Brick",
            };
            Assert.AreEqual("Brick", _material.Name);
        }

        [TestMethod]
        public void SetColor_validColor_OkTest()
        {
            Color _newColor = new Color();

            _material = new Material()
            {
                Color = _newColor,
            };

            Assert.AreEqual(_newColor, _material.Color);
        }

    }
}
