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


        [TestInitialize]
        public void TestInitialize()
        {
            _materialController = new MaterialController();
        }

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
                Color = newColor
            };

            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(newMaterial, currentClient.Username);

            CollectionAssert.Contains(_materialController.Repository.GetMaterialsByClient("user"), newMaterial);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddMaterial_DuplicatedMaterial_OkTest()
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
                Color = newColor
            };

            Client currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(newMaterial, currentClient.Username);
            _materialController.AddMaterial(newMaterial, currentClient.Username);

            Assert.AreEqual(1, _materialController.Repository.GetMaterialsByClient("user").Count);
        }
    }
}
