using MemoryRepository.Exceptions;
using MemoryRepository.MaterialRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;
using System.Linq;

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

            Material NewMaterial = new Material()
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

            Material NewMaterial = new Material()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.AddMaterial(NewMaterial);

        }

        public void RemoveMaterial_FailTest()
        {

            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new Material()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };


            _materialRepository.AddMaterial(NewMaterial);
            _materialRepository.RemoveMaterial(NewMaterial);
            List<Material> materials = _materialRepository.GetMaterialsByClient("OwnerName");

            Assert.IsFalse(materials.Any());
        }

        public void RemoveMaterial_NotExistingMaterial_FailTest()
        {
            Color NewColor = new Color()
            {
                Red = 222,
                Green = 222,
                Blue = 222,
            };

            Material NewMaterial = new Material()
            {
                Name = "Test",
                Owner = "OwnerName",
                Color = NewColor,
            };

            _materialRepository.RemoveMaterial(NewMaterial);
            List<Material> materials = _materialRepository.GetMaterialsByClient("OwnerName");

            Assert.IsFalse(materials.Any());
        }

    }
}
