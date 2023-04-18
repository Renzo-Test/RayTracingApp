using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections.Generic;
using Controller.MaterialExceptions;
using MemoryRepository.Exceptions;
using MemoryRepository.MaterialRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class MaterialRepositoryTest
    {
        private MaterialRepository _materialRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _materialRepository = new MaterialRepository();
        }

        [TestMethod]
        public void GetFiguresByClient_OwnerName_OkTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new MaterialEnum()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.AddMaterial(NewMaterial);

            Assert.AreEqual(NewMaterial, _materialRepository.GetMaterialsByClient("OwnerName")[0]);
        }

        [TestMethod]
        public void AddMaterial_OkTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new MaterialEnum()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.AddMaterial(NewMaterial);

        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundMaterialException))]
        public void RemoveMaterial_OkTest()
        {

            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new MaterialEnum()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };


            _materialRepository.AddMaterial(NewMaterial);
            _materialRepository.RemoveMaterial(NewMaterial);
            _materialRepository.GetMaterialsByClient("OwnerName");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundMaterialException))]
        public void RemoveMaterial_NotExistingMaterial_OkTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new MaterialEnum()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.RemoveMaterial(NewMaterial);
            _materialRepository.GetMaterialsByClient("OwnerName");
        }

    }
}
