using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.ModelsTest
{
	[TestClass]


	public class LogTest
	{
		private Log _log;

		[TestMethod]
		public void CanCreateLog_OkTest()
		{
			_log = new Log();
		}

		[TestMethod]
		public void SetUsername_OkTest()
		{
			_log = new Log()
			{
				Owner = new Client()
				{
					Username = "Username123"
				}
			};
			Assert.AreEqual("Username123", _log.Owner.Username);
		}

		[TestMethod]
		public void SetRenderDate_OkTest()
		{
			_log = new Log()
			{
				RenderDate = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy")
			};
			string expected = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
			Assert.AreEqual(expected, _log.RenderDate);
		}

		[TestMethod]
		public void SetTimeSpan_OkTest()
		{
			_log = new Log()
			{
				TimeSpan = "1 segundos"
			};

			Assert.AreEqual("1 segundos", _log.TimeSpan);
		}

		[TestMethod]
		public void SetSceneName_OkTest()
		{
			_log = new Log()
			{
				SceneName = "Test"
			};

			Assert.AreEqual("Test", _log.SceneName);
		}

		[TestMethod]
		public void SetRenderedElements_OkTest()
		{
			_log = new Log()
			{
				RenderedElements = 5
			};

			Assert.AreEqual(5, _log.RenderedElements);
		}

	}
}

