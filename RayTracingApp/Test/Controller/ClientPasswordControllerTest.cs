using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Test.Controller
{
    [TestClass]
    public class ClientPasswordControllerTest
    {

        [TestMethod]
        public void CheckIfContainsNumber_EmptyString_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsNumber("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfContainsNumber_1_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsNumber("1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfContainsNumber_a1_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsNumber("a1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfContainsCapital_EmptyString_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsCapital("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfContainsCapital_A_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsCapital("A");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfContainsCapital_aA_OkTest()
        {
            bool result = ClientPasswordController.CheckIfContainsCapital("aA");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfLengthInRange_EmptyString_OkTest()
        {
            bool result = ClientPasswordController.CheckIfLengthInRange("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfLengthInRange_ABCDE_OkTest()
        {
            bool result = ClientPasswordController.CheckIfLengthInRange("ABCDE");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfLengthInRange_ABCDEFGHIJKLMNOPQRSTUVWXYZ_OkTest()
        {
            bool result = ClientPasswordController.CheckIfLengthInRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.IsFalse(result);
        }

    }
}
