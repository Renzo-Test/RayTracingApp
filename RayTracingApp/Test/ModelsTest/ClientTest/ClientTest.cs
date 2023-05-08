using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ClientTest
	{
		private Client _client;

		[TestMethod]
		public void CanCreateClient_OkTest()
		{
			_client = new Client();
		}

		[TestMethod]
		public void SetUsername_Gomez_OkTest()
		{
			_client = new Client()
			{
				Username = "Gomez",
			};
			Assert.AreEqual("Gomez", _client.Username);
		}

		[TestMethod]
		public void SetPassword_GomezSecret123_OkTest()
		{
			_client = new Client()
			{
				Password = "GomezSecret123",
			};
			Assert.AreEqual("GomezSecret123", _client.Password);
		}

		[TestMethod]
		public void CanGetRegisterDate_OkTest()
		{
			_client = new Client();
			String today = DateTime.Today.ToString("dd/MM/yyyy");
			Assert.AreEqual(today, _client.RegisterDate);
		}

		[TestMethod]
		public void CanRegisterClient_Rodriguez_RodriguezSecret123_OkTest()
		{
			_client = new Client()
			{
				Username = "Rodriguez",
				Password = "RodriguezSecret123",
			};

			Assert.AreEqual("Rodriguez", _client.Username);
			Assert.AreEqual("RodriguezSecret123", _client.Password);
		}
	}
}
