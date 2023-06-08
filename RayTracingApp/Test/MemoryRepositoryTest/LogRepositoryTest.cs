using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DBRepository;
using Domain;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class LogRepositoryTest
    {
        private LogRepository _logRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _logRepository = new LogRepository()
            {
                DBName = "RayTracingAppTestDB"
            };
        }

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

        [TestMethod]
        public void GetLogsByClient_OwnerName_OkTest()
        {
            Log newLog = new Log()
            {
                Username = "OwnerName",
                RenderDate = DateTime.Now.ToString(),

            };
            _logRepository.AddLog(newLog);
           
            Assert.AreEqual(newLog.Username, _logRepository.GetLogsByClient("OwnerName")[0].Username);
        }
    }
}
