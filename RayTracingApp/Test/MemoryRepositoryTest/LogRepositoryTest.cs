using Controller;
using DBRepository;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.MemoryRepositoryTest
{
	[TestClass]
	public class LogRepositoryTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";

		private LogRepository _logRepository;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
			_logRepository = new LogRepository()
			{
				DBName = "RayTracingAppTestDB"
			};

			_clientController = new ClientController(TestDatabase);

			_clientController.SignUp("ownerName", "Password123");
			_owner = _clientController.SignIn("ownerName", "Password123");

			_clientController.SignUp("otherName", "Password123");
			_otherOwner = _clientController.SignIn("otherName", "Password123");
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
				RenderDate = DateTime.Now.ToString(),

			};
			_logRepository.AddLog(newLog, _owner);

			Assert.AreEqual(newLog.Id, _logRepository.GetAllLogs()[0].Id);
		}

		[TestMethod]
		public void GetAllLogs_TwoLogs_OkTest()
		{
			Log firstLog = new Log() { };
			_logRepository.AddLog(firstLog, _owner);

			Log secondLog = new Log() { };
			_logRepository.AddLog(secondLog, _otherOwner);

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
			Log newLog = new Log() { };

			_logRepository.AddLog(newLog, _owner);

			List<Log> iterable = _logRepository.GetAllLogs();

			Assert.AreEqual(newLog.Owner, iterable[0].Owner);
		}
	}
}
