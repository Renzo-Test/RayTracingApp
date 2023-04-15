using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using Controller;

namespace Test.ControllerTest
{
    [TestClass]
    public class MaterialControllerTest
    {
        private MaterialController _materialController;

        [TestMethod]
        public void CreateClientController_OkTest()
        {
            _materialController = new MaterialController();
        }

        [TestMethod]
        public void AddMaterial_ValidMaterial_OkTest()
        {
            Color newColor = new Color()
            {
                Red = 0,
                Green = 1,
                Blue = 2,
            };

            Material newMaterial = new LambertianMaterial()
            {
                Name = "materialName",
                Owner = "ownerName",
                Color = newColor
            }
        }
    }
}
