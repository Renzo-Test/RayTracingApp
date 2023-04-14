using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository.MaterialRepository;
using Model;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class MaterialRepositoryTest
    {
        [TestMethod]
        public void CreateMaterialRepository_OkTest()
        {
            MaterialRepository _materialRepository = new MaterialRepository();
        }

        /*
        [TestMethod]
        public void GetFiguresByClient_OwnerName_OkTest()
        {
            MaterialRepository _materialRepository = new MaterialRepository();

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

        */

        [TestMethod]
        public void AddMaterial_OkTest()
        {
            MaterialRepository _materialRepository = new MaterialRepository();

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

    }
}
