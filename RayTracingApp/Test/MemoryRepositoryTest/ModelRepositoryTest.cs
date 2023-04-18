using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MemoryRepository.Exceptions;
using MemoryRepository;
using MemoryRepository.MaterialRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class ModelRepositoryTest
    {
        private ModelRepository _modelRepository;
        [TestInitialize]
        public void TestInitialize()
        {
            _modelRepository = new ModelRepository();
        }
        [TestMethod]
        public void CreateModelRepositoryOk_Test()
        {
            _modelRepository = new ModelRepository();
        }
        [TestMethod]
        public void GetModelsByClient_Username_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Owner = "OwnerName",
                Name = "Name",
            };
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
            Model NewModel = new Model()
            {
                Owner = "Username",
                Name = "Test",
                Material = NewMaterial,
                Figure = newFigure
            };
            _modelRepository.AddModel(NewModel);
            Assert.AreEqual(NewModel, _modelRepository.GetModelsByClient(NewModel.Owner)[0]);
        }
        [TestMethod]
        public void AddModel_OkTest() 
        {
            Figure newFigure = new Figure()
            {
                Owner = "OwnerName",
                Name = "Name",
            };
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
            Model NewModel = new Model()
            {
                Owner = "Username",
                Name = "Test",
                Material = NewMaterial,
                Figure = newFigure
            };
            _modelRepository.AddModel(NewModel);
        }
        [TestMethod]
        [ExpectedException(typeof(NotFoundModelException))]
        public void RemoveModel_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Owner = "OwnerName",
                Name = "Name",
            };
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
            Model NewModel = new Model()
            {
                Owner = "OwnerName",
                Name = "Test",
                Material = NewMaterial,
                Figure = newFigure
            };
            _modelRepository.AddModel(NewModel);
            _modelRepository.RemoveModel(NewModel);
            List<Model> iterable = _modelRepository.GetModelsByClient("OwnerName");
            CollectionAssert.DoesNotContain(iterable, NewModel);
        }
        [TestMethod]
        [ExpectedException(typeof(NotFoundModelException))]
        public void RemoveModel_NotExistingModel_OkTest()
        {
            Figure newFigure = new Figure()
            {
                Owner = "OwnerName",
                Name = "Name",
            };
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
            Model NewModel = new Model()
            {
                Owner = "OwnerName",
                Name = "Test",
                Material = NewMaterial,
                Figure = newFigure
            };
            _modelRepository.RemoveModel(NewModel);
            _modelRepository.GetModelsByClient("OwnerName");
        }
    }
}
