using Controller;
using Controller.ClientExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Test.ControllerTest
{
    [TestClass]
    public class ClientControllerTest
    {
        private ClientController _controller;

        [TestInitialize]
        public void TestInitialize()
        {
            _controller = new ClientController();
        }

        [TestMethod]
        public void CanCreateClientSignController_OkTest()
        {
            _controller = new ClientController();
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_GomezQuestionMark_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez?", "GomezSecret1");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_Go_GomezSecret1_OkTest()
        {
            _controller.SignUp("Go", "GomezSecret1");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_Gomez_gomezsecret1_OkTest()
        {
            _controller.SignUp("Gomez", "gomezsecret1");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_Gomez_Gom1_OkTest()
        {
            _controller.SignUp("Gomez", "Gom1");
        }

        [TestMethod]
        public void CheckIfClientExists_EmptyString_OkTest()
        {
            bool result = _controller.ClientAlreadyExists("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfClientExists_Gomez_OkTest()
        {
            _controller.Repository.AddClient("Gomez", "GomezSecret");

            bool result = _controller.ClientAlreadyExists("Gomez");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfClientExists_NotFoundUser_OkTest()
        {
            _controller.ClientAlreadyExists("NotFoundUser");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignUp_AlreadyExisting_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            _controller.SignUp("Gomez", "GomezSecret1");
        }

        [ExpectedException(typeof(InvalidCredentialsException))]
        [TestMethod]
        public void CheckSignIn_NotRegistered_Gomez_GomezSecret1_OkTest()
        {
            Client _currentClient = _controller.SignIn("Gomez", "GomezSecret1");
        }

        [TestMethod]
        public void CheckSignIn_Registered_Gomez_GomezSecret1_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            Client _currentClient = _controller.SignIn("Gomez", "GomezSecret1");
            Assert.AreEqual(_currentClient.Username, "Gomez");
        }

        [TestMethod]
        public void GetCurrentClient_SignedOut_EmptyString_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            Client _currentClient = _controller.SignIn("Gomez", "GomezSecret1");
            _controller.SignOut(ref _currentClient);

            Assert.IsNull(_currentClient);
        }

        [TestMethod]
        public void CheckIfClientIsLoggedIn_LoggedInClient_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            Client _currentClient = _controller.SignIn("Gomez", "GomezSecret1");

            bool result = _controller.IsLoggedIn(_currentClient);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfClientIsLoggedIn_LoggedOutClient_OkTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            Client _currentClient = _controller.SignIn("Gomez", "GomezSecret1");
            _controller.SignOut(ref _currentClient);

            bool result = _controller.IsLoggedIn(_currentClient);
            Assert.IsFalse(result);
        }

    }
}
