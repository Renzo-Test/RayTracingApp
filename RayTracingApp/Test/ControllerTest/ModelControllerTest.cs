using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Controller;

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
    }
}
