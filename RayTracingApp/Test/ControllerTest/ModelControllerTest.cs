using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Controller;
using Models;
using MemoryRepository.Exceptions;

namespace Test.ControllerTest
{
    [TestClass]
    public class ModelControllerTest
    {
        private ModelController _modelController;

        [TestInitialize]
        public void Testinitialize()
        {
            _modelController = new ModelController();
        }

        [TestMethod]
        public void CreateModelController_OkTest()
        {
            _modelController = new ModelController();
        }

        [TestMethod]
        public void ListModels_ValidUsername_OkTest() 
        {
            _modelController = new ModelController();
            Model targetModel = new Model()
            {
                Owner = "targetOwner"
            };
            _modelController.Repository.AddModel(targetModel);

            Model anotherModel = new Model()
            {
                Owner = "otherOwner"
            };
            _modelController.Repository.AddModel(anotherModel);

            CollectionAssert.Contains(_modelController.ListModels("targetOwner"), targetModel);
            CollectionAssert.DoesNotContain(_modelController.ListModels("targetOwner"), anotherModel);
        }


        [TestMethod]
        public void ListModels_InvalidUsername_FailTest()
        {
            _modelController.Repository.GetModelsByClient("owner");
        }
    }
}
