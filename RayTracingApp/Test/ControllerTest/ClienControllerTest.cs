using System;
using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.ControllerTest
{
    [TestClass]
    public class ClienControllerTest
    {
        private ClientController _controller;
        public CurrentClient _currentClient;

        [TestInitialize]
        public void TestInitialize()
        {
            _currentClient = new CurrentClient();
            _controller = new ClientController(_currentClient);
        }

        [TestMethod]
        public void CanCreateClientSignController_OkTest()
        {
            _controller = new ClientController(_currentClient);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret1_OkTest()
        {
            bool result = _controller.SignUp("Gomez", "GomezSecret1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSignUp_GomezQuestionMark_GomezSecret1_OkTest()
        {
            bool result = _controller.SignUp("Gomez?", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Go_GomezSecret1_OkTest()
        {
            bool result = _controller.SignUp("Go", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_gomezsecret1_OkTest()
        {
            bool result = _controller.SignUp("Gomez", "gomezsecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret_OkTest()
        {
            bool result = _controller.SignUp("Gomez", "GomezSecret");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_Gom1_OkTest()
        {
            bool result = _controller.SignUp("Gomez", "Gom1");
            Assert.IsFalse(result);
        }

                
        [TestMethod]
        public void CheckIfClientExists_EmptyString_OkTest()
        {
            bool result = _controller.CheckIfClientExists("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfClientExists_Gomez_OkTest()
        {
            _controller.Repository.AddClient("Gomez", "GomezSecret");
            
            bool result = _controller.CheckIfClientExists("Gomez");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfClientExists_NotFoundUser_OkTest()
        {
            bool result = _controller.CheckIfClientExists("NotFoundUser");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_AlreadyExisting_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            bool result = _controller.SignUp("Gomez", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignIn_NotRegistered_Gomez_GomezSecret1_OkTest()
        {
            bool result = _controller.SignIn("Gomez", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignIn_Registered_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            bool result = _controller.SignIn("Gomez", "GomezSecret1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCurrentClient_Signed_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            _controller.SignIn("Gomez", "GomezSecret1");

            Assert.AreEqual(_controller.CurrentClient.Username, "Gomez");
        }

        [TestMethod]
        public void GetCurrentClient_UnsignedClient_EmptyString_OkTest()
        {
            Assert.AreEqual(_controller.CurrentClient.Username, "");
        }

        [TestMethod]
        public void GetCurrentClient_SignedOut_EmptyString_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            _controller.SignIn("Gomez", "GomezSecret1");
            _controller.SignOut();

            Assert.AreEqual(_controller.CurrentClient.Username, "");
        }
    }
}
