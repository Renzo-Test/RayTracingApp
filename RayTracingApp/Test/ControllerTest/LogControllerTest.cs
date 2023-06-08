using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.ControllerTest
{
    [TestClass]
    public class LogControllerTest
    {
        private const string TestDatabase = "RayTracingAppTestDB";

        [TestCleanup]
        public void TestCleanUp()
        {
            using (var context = new DBRepository.AppContext(TestDatabase))
            {
                context.ClearDBTable("Logs");
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
