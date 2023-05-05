using Controller;
using Models.MaterialExceptions;
using MemoryRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;
using System.Linq;
using Controller.MaterialExceptions;

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
            Material _newMaterial = new Material()
            {
                Name = "materialName",
            };

            _materialController.AddMaterial(_newMaterial, "user");

            CollectionAssert.Contains(_materialController.Repository.GetMaterialsByClient("user"), _newMaterial);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMaterialInputException))]
        public void AddMaterial_DuplicatedMaterial_FailTest()
        {
            Material _newMaterial = new Material()
            {
                Name = "materialName",
            };

            _materialController.AddMaterial(_newMaterial, "user");
            _materialController.AddMaterial(_newMaterial, "user");
        }

        [TestMethod]
        public void AddMaterial_TwoValidMaterials_OkTest()
        {
            Material _firstMaterial = new Material()
            {
                Name = "materialOne",
            };

            Material _secondMaterial = new Material()
            {
                Name = "materialTwo",
            };

            _materialController.AddMaterial(_firstMaterial, "user");
            _materialController.AddMaterial(_secondMaterial, "user");

            Assert.AreEqual(2, _materialController.Repository.GetMaterialsByClient("user").Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMaterialInputException))]
        public void AddMaterial_SpacedMaterialName_FailTest()
        {
            Material newMaterial = new Material()
            {
                Name = " spacedName ",
            };

            _materialController.AddMaterial(newMaterial, "user");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMaterialInputException))]
        public void AddMaterial_EmptyMaterialName_FailTest()
        {
            Material newMaterial = new Material()
            {
                Name = "",
            };

            _materialController.AddMaterial(newMaterial, "user");
        }

        [TestMethod]
        public void ListMaterials_OkTest()
        {
            Material firstMaterial = new Material()
            {
                Name = "materialOne",
            };
            _materialController.AddMaterial(firstMaterial, "username");

            Material secondMaterial = new Material()
            {
                Name = "materialTwo",
            };
            _materialController.AddMaterial(secondMaterial, "username");

            Assert.AreEqual(2, _materialController.ListMaterials("username").Count);
        }

        public void RemoveMaterials_OkTest()
        {
            Material newMaterial = new Material()
            {
                Name = "materialName",
            };

            List<Model> models = new List<Model>();

            _materialController.AddMaterial(newMaterial, "username");
            _materialController.RemoveMaterial(newMaterial.Name, "username", models);

            List<Material> materials = _materialController.ListMaterials("username");
            Assert.IsFalse(materials.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(MaterialUsedByModelException))]
        public void RemoveMaterial_MaterialUsedByModel_FailTest()
        {
            Material material = new Material()
            {
                Owner = "ownerName",
                Name = "materialName",
            };

            Model model = new Model()
            {
                Material = material,
                Owner = "ownerName"
            };
            ModelController modelController = new ModelController();
            modelController.Repository.AddModel(model);
            _materialController.AddMaterial(material, material.Owner);

            _materialController.RemoveMaterial("materialName", "ownerName", modelController.ListModels("ownerName"));
        }

        [TestMethod]
        public void GetMaterial_ExistingMaterial_OkTest()
        {
            Client currentClient = new Client()
            {
                Username = "Username123",
                Password = "Password123"
            };

            Material newMaterial = new Material()
            {
                Name = "sphere",
            };

            _materialController.AddMaterial(newMaterial, currentClient.Username);
            Material expected = _materialController.GetMaterial(currentClient.Username, newMaterial.Name);

            Assert.AreEqual(expected, newMaterial);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundMaterialException))]
        public void GetMaterial_ExistingMaterial_FailTest()
        {
            Client currentClient = new Client()
            {
                Username = "Username123",
                Password = "Password123"
            };

            _materialController.GetMaterial("newFigure", currentClient.Username);
        }
    }
}
