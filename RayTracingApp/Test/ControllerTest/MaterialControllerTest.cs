using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.ControllerTest
{
    [TestClass]
    public class MaterialControllerTest
    {
        [TestMethod]
        public void CreateClientController_OkTest()
        {
            _materialController = new MaterialController();
        }
    }
}
