using Controller;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.ControllerTest
{
	[TestClass]
	public class LogControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private LogController _logController;

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext(TestDatabase))
			{
				context.ClearDBTable("Logs");
			}
		}

		[TestInitialize]
		public void TestInitialize()
		{
			_logController = new LogController(TestDatabase);
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
				Username = "User1",
				RenderTime = 150,
			};

			Log testLog2 = new Log()
			{
				Username = "User2",
				RenderTime = 100,
			};

			_logController.AddLog(testLog1);
			_logController.AddLog(testLog2);

			Assert.AreEqual("User1", _logController.GetUserWithMaxAccumulatedRenderTime());
		}

		[TestMethod]

		public void GetTotalRenderTimeInMinutes_OkTest()
		{
			Log testLog1 = new Log()
			{
				Username = "User1",
				RenderTime = 150,
			};

			Log testLog2 = new Log()
			{
				Username = "User2",
				RenderTime = 100,
			};

			_logController.AddLog(testLog1);
			_logController.AddLog(testLog2);

			Assert.AreEqual(4, _logController.GetTotalRenderTimeInMinutes());
		}

		[TestMethod]

		public void GetAverageRenderTimeInSeconds_OkTest()
		{
			Log testLog1 = new Log()
			{
				Username = "User1",
				RenderTime = 200,
			};

			Log testLog2 = new Log()
			{
				Username = "User2",
				RenderTime = 100,
			};

			_logController.AddLog(testLog1);
			_logController.AddLog(testLog2);

			Assert.AreEqual(150, _logController.GetAverageRenderTimeInSeconds());
		}
	}
}
