using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;


namespace Test.Model
{
    [TestClass]
    public class ClientTest
    {
        private Client _client;

        [TestMethod]
        public void canCreateClient_OkTest()
        {
           _client = new Client();
        }

        [TestMethod]
        public void setUsername_Gomez_OkTest()
        {
            _client = new Client()
            {
                Username = "Gomez",
            };
            Assert.AreEqual("Gomez", _client.Username);
        }

        [TestMethod]
        public void setPassword_GomezSecret_OkTest()
        {
            _client = new Client()
            {
                Password = "GomezSecret",
            };
            Assert.AreEqual("GomezSecret", _client.Password);
        }

        [TestMethod]
        public void canGetRegisterDate_OkTest()
        {
            _client = new Client();
            String today = DateTime.Today.ToString("dd/MM/yyyy");
            Assert.AreEqual(today, _client.RegisterDate);
        }
    }
}
