﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using Controller;
using MemoryRepository.Exceptions;
using Controller.MaterialExceptions;
using Controller.FigureExceptions;
using System.Collections.Generic;

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
            Material _newMaterial = new MaterialEnum()
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
            Material _newMaterial = new MaterialEnum()
            {
                Name = "materialName",
            };

            _materialController.AddMaterial(_newMaterial, "user");
            _materialController.AddMaterial(_newMaterial, "user");
        }

        [TestMethod]
        public void AddMaterial_TwoValidMaterials_OkTest()
        {
            Material _firstMaterial = new MaterialEnum()
            {
                Name = "materialOne",
            };

            Material _secondMaterial = new MaterialEnum()
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
            Material newMaterial = new MaterialEnum()
            {
                Name = " spacedName ",
            };

            _materialController.AddMaterial(newMaterial, "user");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMaterialInputException))]
        public void AddMaterial_EmptyMaterialName_FailTest()
        {
            Material newMaterial = new MaterialEnum()
            {
                Name = "",
            };

            _materialController.AddMaterial(newMaterial, "user");
        }

        [TestMethod]
        public void ListMaterials_OkTest()
        {
            Material firstMaterial = new MaterialEnum()
            {
                Name = "materialOne",
            };
            _materialController.AddMaterial(firstMaterial, "username");

            Material secondMaterial = new MaterialEnum()
            {
                Name = "materialTwo",
            };
            _materialController.AddMaterial(secondMaterial, "username");

            Assert.AreEqual(2, _materialController.ListMaterials("username").Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundMaterialException))]
        public void RemoveMaterials_OkTest()
        {
            Material newMaterial = new MaterialEnum()
            {
                Name = "materialName",
            };

            List<Model> models = new List<Model>();

            _materialController.AddMaterial(newMaterial, "username");
            _materialController.RemoveMaterial(newMaterial.Name, "username", models);

            _materialController.ListMaterials("username");
        }

        [TestMethod]
        [ExpectedException(typeof(MaterialUsedByModelException))]
        public void RemoveMaterial_MaterialUsedByModel_OkTest()
        {
            Material material = new MaterialEnum()
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
    }
}
