using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DBRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class LogRepositoryTest
    {
        private LogRepository _logRepository;
        [TestCleanup]
        public void TestCleanUp()
        {
            using (var context = new DBRepository.AppContext("RayTracingAppTestDB"))
            {
                context.ClearDBTable("Logs");
            }
        }

        [TestMethod]
        public void CanCreateLogRepository_OkTest()
        {
            _logRepository = new LogRepository();
        }
    }
}
