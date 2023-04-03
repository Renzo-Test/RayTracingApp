using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;


namespace Test.Controller
{
    [TestClass]

    public class ClientUsernameControllerTest
    {

        [TestMethod]
        public void CheckIfLengthInRange_EmptyString_OkTest()
        {
            bool result = ClientUsernameController.CheckIfLengthInRange("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfLengthInRange_ABC_OkTest()
        {
            bool result = ClientUsernameController.CheckIfLengthInRange("ABC");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfLengthInRange_ABCDEFGHIJKLMNOPQRSTU_OkTest()
        {
            bool result = ClientUsernameController.CheckIfLengthInRange("ABCDEFGHIJKLMNOPQRSTU");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_EmptyString_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric("");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_QuestionMark_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric("?");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_AQuestionMarkB_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric("A?B");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_SpaceAB_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric(" AB");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_ASpaceB_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric("A B");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfAlphanumeric_ABSpace_OkTest()
        {
            bool result = ClientUsernameController.CheckIfAlphanumeric("AB ");
            Assert.IsFalse(result);
        }

    }
}
