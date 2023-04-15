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
        public void AddMaterial_DuplicatedMaterial_FailTest()
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

            _materialController.AddMaterial(_firstMaterial, _currentClient.Username);
            _materialController.AddMaterial(_secondMaterial, _currentClient.Username);

            Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient("user").Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddMaterial_SpacedMaterialName_FailTest()
        {
            Material newMaterial = new LambertianMaterial()
            {
                Name = " spacedName ",
            };

            Client _currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(newMaterial, _currentClient.Username);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddMaterial_EmptyMaterialName_FailTest()
        {
            Material newMaterial = new LambertianMaterial()
            {
                Name = "",
            };

            Client _currentClient = new Client()
            {
                Username = "user",
                Password = "pass"
            };

            _materialController.AddMaterial(newMaterial, _currentClient.Username);
        }

        [TestMethod]
        public void ListMaterials_OkTest()
        {
            Material firstMaterial = new LambertianMaterial()
            {
                Name = "materialOne",
            };
            _materialController.AddMaterial(firstMaterial, "username");

            Material secondMaterial = new LambertianMaterial()
            {
                Name = "materialTwo",
            };
            _materialController.AddMaterial(secondMaterial, "username");

            Assert.AreEqual(2, _materialController.ListMaterials("username").Count);
        }
    }
}
