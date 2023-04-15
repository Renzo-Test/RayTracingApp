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
        private Color _newColor;
        private Material _newMaterial;
        private Client _currentClient;

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
            Material _newMaterial = new LambertianMaterial()
            {
                Name = "materialName",
            };

            Client _currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(_newMaterial, _currentClient.Username);

            CollectionAssert.Contains(_materialController.Repository.GetMaterialsByClient("user"), _newMaterial);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddMaterial_DuplicatedMaterial_OkTest()
        {
            Material _newMaterial = new LambertianMaterial()
            {
                Name = "materialName",
            };

            Client _currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(_newMaterial, _currentClient.Username);
            _materialController.AddMaterial(_newMaterial, _currentClient.Username);

            Assert.AreEqual(1, _materialController.Repository.GetMaterialsByClient("user").Count);
        }

        [TestMethod]
        public void AddMaterial_TwoValidMaterials_OkTest()
        {
            Material _firstMaterial = new LambertianMaterial()
            {
                Name = "materialOne",
            };

            Material _secondMaterial = new LambertianMaterial()
            {
                Name = "materialTwo",
            };

            Client _currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(_newMaterial, _currentClient.Username);
            _materialController.AddMaterial(_newMaterial, _currentClient.Username);

            Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient("user").Count);
        }
    }
}
