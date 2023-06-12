using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DBRepository;
using Domain;
using System.Collections.Generic;

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
            using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
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
        public void GetAllLogs_OkTest()
        {
            Log newLog = new Log()
            {
                Username = "OwnerName",
                RenderDate = DateTime.Now.ToString(),

            };
            _logRepository.AddLog(newLog);

            Assert.AreEqual(newLog.Id, _logRepository.GetAllLogs()[0].Id);
        }

        [TestMethod]
        public void GetAllLogs_TwoLogs_OkTest()
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

            Assert.AreEqual(firstLog.Id, _logRepository.GetAllLogs()[0].Id);
            Assert.AreEqual(secondLog.Id, _logRepository.GetAllLogs()[1].Id);
        }

        [TestMethod]
        public void GetAllLogs_NotExistingLog()
        {
            _logRepository.GetAllLogs();
        }

        [TestMethod]
        public void AddLog_OkTest()
        {
            Log newLog = new Log()
            {
                Username = "Username123"
            };

            _logRepository.AddLog(newLog);

            List<Log> iterable = _logRepository.GetAllLogs();

            Assert.AreEqual(newLog.Username, iterable[0].Username);
        }
    }
}
