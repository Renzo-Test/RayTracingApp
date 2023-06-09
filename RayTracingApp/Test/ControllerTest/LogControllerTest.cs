using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Controller;

namespace Test.ControllerTest
{
    [TestClass]
    public class LogControllerTest
    {
        private const string TestDatabase = "RayTracingAppTestDB";
        private LogController _controller;

        [TestCleanup]
        public void TestCleanUp()
        {
            using (var context = new DBRepository.AppContext(TestDatabase))
            {
                context.ClearDBTable("Logs");
            }
        }

        [TestMethod]
        public void CanCreateLogController_OkTest()
        {
            _controller = new LogController();
        }
    }
}
