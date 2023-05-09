﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
		public void SetDefaultFov_OkTest()
		{

			_client = new Client()
			{
				DefaultFov = 55
			};

			Assert.AreEqual(55, _client.DefaultFov);
		}

		[TestMethod]
		public void SetDefaultLookFrom_OkTest()
		{
			Vector defaultVector = new Vector()
			{
				X = 2,
				Y = 3,
				Z = 4,
			};
			_client = new Client()
			{
				DefaultLookFrom = defaultVector
			};

			Assert.AreEqual(defaultVector, _client.DefaultLookFrom);
		}

		[TestMethod]
		public void SetDefaultLookAt_OkTest()
		{
			Vector defaultVector = new Vector()
			{
				X = 1,
				Y = 2,
				Z = 3,
			};
			_client = new Client()
			{
				DefaultLookAt = defaultVector
			};

			Assert.AreEqual(defaultVector, _client.DefaultLookAt);
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
