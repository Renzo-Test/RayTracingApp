using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;


namespace Test.ControllerTest
{
    [TestClass]

    public class ClientValidatorTest
    {

        [TestMethod]
        public void LengthInRangeUsername_EmptyString_OkTest()
        {
            bool result = ClientValidator.LengthInRangeUsername("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthInRangeUsername_ABC_OkTest()
        {
            bool result = ClientValidator.LengthInRangeUsername("ABC");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthInRangeUsername_ABCDEFGHIJKLMNOPQRSTU_OkTest()
        {
            bool result = ClientValidator.LengthInRangeUsername("ABCDEFGHIJKLMNOPQRSTU");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Alphanumeric_EmptyString_OkTest()
        {
            bool result = ClientValidator.Alphanumeric("");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Alphanumeric_QuestionMark_OkTest()
        {
            bool result = ClientValidator.Alphanumeric("?");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Alphanumeric_AQuestionMarkB_OkTest()
        {
            bool result = ClientValidator.Alphanumeric("A?B");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Alphanumeric_SpaceAB_OkTest()
        {
            bool result = ClientValidator.Alphanumeric(" AB");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Alphanumeric_ASpaceB_OkTest()
        {
            bool result = ClientValidator.Alphanumeric("A B");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Alphanumeric_ABSpace_OkTest()
        {
            bool result = ClientValidator.Alphanumeric("AB ");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsNumber_EmptyString_OkTest()
        {
            bool result = ClientValidator.ContainsNumber("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsNumber_1_OkTest()
        {
            bool result = ClientValidator.ContainsNumber("1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsNumber_a1_OkTest()
        {
            bool result = ClientValidator.ContainsNumber("a1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsCapital_EmptyString_OkTest()
        {
            bool result = ClientValidator.ContainsCapital("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsCapital_A_OkTest()
        {
            bool result = ClientValidator.ContainsCapital("A");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsCapital_aA_OkTest()
        {
            bool result = ClientValidator.ContainsCapital("aA");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthInRangePassword_EmptyString_OkTest()
        {
            bool result = ClientValidator.LengthInRangePassword("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthInRangePassword_ABCDE_OkTest()
        {
            bool result = ClientValidator.LengthInRangePassword("ABCDE");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthInRangePassword_ABCDEFGHIJKLMNOPQRSTUVWXYZ_OkTest()
        {
            bool result = ClientValidator.LengthInRangePassword("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.IsFalse(result);
        }


    }
}
