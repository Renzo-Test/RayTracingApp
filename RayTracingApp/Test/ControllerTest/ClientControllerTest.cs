using Controller;
using Controller.ClientExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.ClientExceptions;

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

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_GomezQuestionMark_GomezSecret1_FailTest()
        {
            _controller.SignUp("Gomez?", "GomezSecret1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_Go_GomezSecret1_FailTest()
        {
            _controller.SignUp("Go", "GomezSecret1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_Gomez_gomezsecret1_FailTest()
        {
            _controller.SignUp("Gomez", "gomezsecret1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_Gomez_GomezSecret_FailTest()
        {
            _controller.SignUp("Gomez", "GomezSecret");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_Gomez_Gom1_FailTest()
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
            _controller.Repository.AddClient("Gomez", "GomezSecret123");

            bool result = _controller.ClientAlreadyExists("Gomez");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfClientExists_NotFoundUser_OkTest()
        {
            _controller.ClientAlreadyExists("NotFoundUser");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignUp_AlreadyExisting_Gomez_GomezSecret1_FailTest()
        {
            _controller.SignUp("Gomez", "GomezSecret1");
            _controller.SignUp("Gomez", "GomezSecret1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void CheckSignIn_NotRegistered_Gomez_GomezSecret1_FailTest()
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
        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void LengthInRangeUsername_EmptyString_FailTest()
        {
            _controller.SignUp("", "Password123");
        }

        [TestMethod]
        public void LengthInRangeUsername_Abc123_OkTest()
        {
            _controller.SignUp("Abc123", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void LengthInRangeUsername_ABCDEFGHIJKLMNOPQRSTU_FailTest()
        {
            _controller.SignUp("ABCDEFGHIJKLMNOPQRSTU123", "Password123");
        }

        [TestMethod]
        public void Alphanumeric_Abc123_OkTest()
        {
            _controller.SignUp("Abc123", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void Alphanumeric_Abcde_FailTest()
        {
            _controller.SignUp("Abcde?", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void Alphanumeric_QuestionMark_FailTest()
        {
            _controller.SignUp("?", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void Alphanumeric_SpaceAbcde123_FailTest()
        {
            _controller.SignUp(" Abcde123", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void Alphanumeric_AbSpaceCd123_FailTest()
        {
            _controller.SignUp("Ab Cd123", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void Alphanumeric_Ab123Space_FailTest()
        {
            _controller.SignUp("Ab123 ", "Password123");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void ContainsNumber_abcde_FailTest()
        {
            _controller.SignUp("Username123", "abcde");
        }

        [TestMethod]
        public void ContainsNumber_abcd1_OkTest()
        {
            _controller.SignUp("Username123", "Abcd1");
        }

        [TestMethod]
        public void ContainsNumber_ABCdEFG1_OkTest()
        {
            _controller.SignUp("Username123", "ABCdEFG1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void ContainsCapital_abcd1_FailTest()
        {
            _controller.SignUp("Username123", "abcd1");
        }

        [TestMethod]
        public void ContainsCapital_Abcd1_OkTest()
        {
            _controller.SignUp("Username123", "Abcd1");
        }

        [TestMethod]
        public void ContainsCapital_ABCdEFG1_OkTest()
        {
            _controller.SignUp("Username123", "ABCdEFG1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void LengthInRangePassword_EmptyString_FailTest()
        {
            _controller.SignUp("Username123", "");
        }

        [TestMethod]
        public void LengthInRangePassword_Abcd1_OkTest()
        {
            _controller.SignUp("Username123", "Abcd1");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void LengthInRangePassword_ABCDEFGHIJKLMNOPQRSTUVWXYZ_FailTest()
        {
            _controller.SignUp("Username123", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }

    }
}
