using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using Controller;

namespace Test.ControllerTest
{
    [TestClass]
    public class MaterialControllerTest
    {
        private MaterialController _materialController;

        [TestMethod]
        public void CreateClientController_OkTest()
        {
            _materialController = new MaterialController();
        }
    }
}
