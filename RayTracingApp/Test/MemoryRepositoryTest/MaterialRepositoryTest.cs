using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository.MaterialRepository;
using Model;
using System.Collections.Generic;

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

            Material NewMaterial = new LambertianMaterial()
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

            Material NewMaterial = new LambertianMaterial()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.AddMaterial(NewMaterial);

        }

        [TestMethod]
        public void RemoveMaterial_OkTest()
        {

            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new LambertianMaterial()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };


            _materialRepository.AddMaterial(NewMaterial);
            _materialRepository.RemoveMaterial(NewMaterial);
            List<Material> iterable = _materialRepository.GetMaterialsByClient("OwnerName");

            CollectionAssert.DoesNotContain(iterable, NewMaterial);

        }

        [TestMethod]
        public void RemoveMaterial_NotExistingMaterial_OkTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new LambertianMaterial()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.RemoveMaterial(NewMaterial);
            List<Material> iterable = _materialRepository.GetMaterialsByClient("OwnerName");

            CollectionAssert.DoesNotContain(iterable, NewMaterial);

        }

    }
}
