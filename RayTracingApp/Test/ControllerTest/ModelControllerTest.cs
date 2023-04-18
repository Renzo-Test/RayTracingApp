using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Controller;
using Models;

namespace Test.ControllerTest
{
    [TestClass]
    public class ModelControllerTest
    {
        [TestMethod]
        public void CreateModelController_OkTest()
        {
            ModelController controller = new ModelController();
        }

        [TestMethod]
        public void ListModels_ValidUsername_OkTest() 
        {
            ModelController controller = new ModelController();
            Model newModel = new Model()
            {
                Owner = "ownerName"
            };
            controller.Repository.AddModel(newModel);

            Model anotherModel = new Model()
            {
                Owner = "otherOwner"
            };
            controller.Repository.AddModel(anotherModel);

            CollectionAssert.Contains(controller.Repository.GetModelsByClient("ownerName"), newModel);
            CollectionAssert.DoesNotContain(controller.Repository.GetModelsByClient("ownerName"), anotherModel);
        }
    }
}
