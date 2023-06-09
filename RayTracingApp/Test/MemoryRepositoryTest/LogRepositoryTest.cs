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
        public void GetLogsByUsername_OwnerName_OkTest()
        {
            Log newLog = new Log()
            {
                Username = "OwnerName",
                RenderDate = DateTime.Now.ToString(),

            };
            _logRepository.AddLog(newLog);

            Assert.AreEqual(newLog.Username, _logRepository.GetLogsByUsername("OwnerName")[0].Username);
        }

        [TestMethod]
        public void GetLogsByUsername_TwoUsernames_OkTest()
        {
            Log firstLog = new Log()
            {
                Username = "Log1"
            };
            _logRepository.AddLog(firstLog);

            Log secondLog = new Log()
            {
                Username = "Log2"
            };
            _logRepository.AddLog(secondLog);

            Assert.AreEqual("Log1", _logRepository.GetLogsByUsername("Log1")[0].Username);
            Assert.AreEqual("Log2", _logRepository.GetLogsByUsername("Log2")[0].Username);
        }

        [TestMethod]
        public void GetLogsByUsername_NotExistingUsername()
        {
            _logRepository.GetLogsByUsername("");
        }
    }
}
