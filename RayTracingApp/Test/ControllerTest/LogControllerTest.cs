using Controller;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.ControllerTest
{
	[TestClass]
	public class LogControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private LogController _logController;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
			using (var context = new DBRepository.TestAppContext(TestDatabase))
			{
				context.ClearDBTable("Logs");
				context.ClearDBTable("Clients");
			}

			_logController = new LogController(TestDatabase);
			_clientController = new ClientController(TestDatabase);

			_clientController.SignUp("ownerName", "Password123");
			_owner = _clientController.SignIn("ownerName", "Password123");

			_clientController.SignUp("otherName", "Password123");
			_otherOwner = _clientController.SignIn("otherName", "Password123");
		}


		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext(TestDatabase))
			{
				context.ClearDBTable("Logs");
				context.ClearDBTable("Clients");
			}
		}

		[TestMethod]
		public void CanCreateLogController_OkTest()
		{
			_logController = new LogController();
		}

		[TestMethod]

		public void GetUserWithMaxAccumulatedRenderTime_OkTest()
		{
			Log testLog1 = new Log()
			{
				RenderTime = 150,
			};

			Log testLog2 = new Log()
			{
				RenderTime = 100,
			};

			_logController.AddLog(testLog1, _owner);
			_logController.AddLog(testLog2, _otherOwner);
			string username;
			(username, _) = _logController.GetUserWithMaxAccumulatedRenderTime();

			Assert.AreEqual(_owner.Username, username);
		}

		[TestMethod]

		public void GetTotalRenderTimeInMinutes_OkTest()
		{
			Log testLog1 = new Log()
			{
				RenderTime = 150,
			};

			Log testLog2 = new Log()
			{
				RenderTime = 100,
			};

			_logController.AddLog(testLog1, _owner);
			_logController.AddLog(testLog2, _otherOwner);

			Assert.AreEqual(4, _logController.GetTotalRenderTimeInMinutes());
		}

		[TestMethod]

		public void GetAverageRenderTimeInSeconds_OkTest()
		{
			Log testLog1 = new Log()
			{
				RenderTime = 200,
			};

			Log testLog2 = new Log()
			{
				RenderTime = 100,
			};

			_logController.AddLog(testLog1, _owner);
			_logController.AddLog(testLog2, _owner);

			Assert.AreEqual(150, _logController.GetAverageRenderTimeInSeconds());
		}

		[TestMethod]

		public void GetRenderTimeWindow_Preview_OkTest()
		{
            Log testLog1 = new Log()
            {
				RenderDate = "2023-06-01 12:00:00",
                RenderTime = 200,
				TimeSpan = "0 seconds",
				SceneName = "preview-Test"
            };

            _logController.AddLog(testLog1, _owner);
            List<Log> logs = _logController.ListLogs();

            Log testLog2 = new Log()
            {
                RenderDate = "2023-06-01 13:00:00",
                RenderTime = 100,
				SceneName = "Test",
				TimeSpan = _logController.GetRenderTimeWindow("Test",logs)
            };

            _logController.AddLog(testLog2, _owner);

            Assert.AreEqual("0 seconds", testLog2.TimeSpan);

        }

		[TestMethod]
        public void GetRenderTimeWindow_Render_OkTest()
        {
            Log testLog1 = new Log()
            {
                RenderDate = "2023-06-01 12:00:00",
                RenderTime = 200,
                TimeSpan = "0 seconds",
                SceneName = "Test"
            };

            _logController.AddLog(testLog1, _owner);
            List<Log> logs = _logController.ListLogs();

            Log testLog2 = new Log()
            {
                RenderDate = "2023-06-01 13:00:00",
                RenderTime = 100,
                SceneName = "Test",
                TimeSpan = _logController.GetRenderTimeWindow("Test", logs)
            };

            Assert.AreEqual("1 hours", testLog2.TimeSpan);

        }

        [TestMethod]
        public void GetRenderTimeWindow_SecondRender_OkTest()
        {
            Log testLog1 = new Log()
            {
                RenderDate = "2023-06-01 12:00:00",
                RenderTime = 200,
                TimeSpan = "0 seconds",
                SceneName = "Test"
            };

            _logController.AddLog(testLog1, _owner);
            List<Log> logs = _logController.ListLogs();

            Log testLog2 = new Log()
            {
                RenderDate = "2023-06-02 13:00:00",
                RenderTime = 100,
                SceneName = "Test",
                TimeSpan = _logController.GetRenderTimeWindow("Test", logs)
            };

            Assert.AreEqual("1 days", testLog2.TimeSpan);

        }

    }
}
