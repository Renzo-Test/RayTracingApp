using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;


namespace Test.ModelsTest
{
    [TestClass]
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
        public void SetPassword_GomezSecret_OkTest()
        {
            _client = new Client()
            {
                Password = "GomezSecret",
            };
            Assert.AreEqual("GomezSecret", _client.Password);
        }

        [TestMethod]
        public void CanGetRegisterDate_OkTest()
        {
            _client = new Client();
            String today = DateTime.Today.ToString("dd/MM/yyyy");
            Assert.AreEqual(today, _client.RegisterDate);
        }

        [TestMethod]
        public void CanRegisterClient_Rodriguez_RodriguezSecret_OkTest()
        {
            _client = new Client()
            {
                Username = "Rodriguez",
                Password = "RodriguezSecret",
            };

            Assert.AreEqual("Rodriguez", _client.Username);
            Assert.AreEqual("RodriguezSecret", _client.Password);
        }
    }
}
