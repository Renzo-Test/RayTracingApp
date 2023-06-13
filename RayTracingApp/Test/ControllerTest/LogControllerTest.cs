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
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;

		[TestInitialize]
		public void TestInitialize()
		{
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

			Assert.AreEqual(_owner.Username, _logController.GetUserWithMaxAccumulatedRenderTime());
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
	}
}
