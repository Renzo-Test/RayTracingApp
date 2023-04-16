using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using Controller.ClientExceptions;


namespace Test.ControllerTest
{
    [TestClass]

    public class ClientValidatorTest
    {

        [ExpectedException(typeof(NotInExpectedRangeException))]
        [TestMethod]
        public void LengthInRangeUsername_EmptyString_OkTest()
        {
            ClientValidator.LengthInRangeUsername("");
        }

        [TestMethod]
        public void LengthInRangeUsername_ABC_OkTest()
        {
            ClientValidator.LengthInRangeUsername("ABC");
        }

        [ExpectedException(typeof(NotInExpectedRangeException))]
        [TestMethod]
        public void LengthInRangeUsername_ABCDEFGHIJKLMNOPQRSTU_OkTest()
        {
            ClientValidator.LengthInRangeUsername("ABCDEFGHIJKLMNOPQRSTU");
        }

        [TestMethod]
        public void Alphanumeric_EmptyString_OkTest()
        {
            ClientValidator.IsAphanumeric("");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void Alphanumeric_QuestionMark_OkTest()
        {
            ClientValidator.IsAphanumeric("?");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void Alphanumeric_AQuestionMarkB_OkTest()
        {
            ClientValidator.IsAphanumeric("A?B");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void Alphanumeric_SpaceAB_OkTest()
        {
            ClientValidator.IsAphanumeric(" AB");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void Alphanumeric_ASpaceB_OkTest()
        {
            ClientValidator.IsAphanumeric("A B");
        }

        [ExpectedException(typeof(NotAlphanumericException))]
        [TestMethod]
        public void Alphanumeric_ABSpace_OkTest()
        {
            ClientValidator.IsAphanumeric("AB ");
        }

        [ExpectedException(typeof(NotContainsNumberException))]
        [TestMethod]
        public void ContainsNumber_EmptyString_OkTest()
        {
            ClientValidator.ContainsNumber("");
        }

        [TestMethod]
        public void ContainsNumber_1_OkTest()
        {
            ClientValidator.ContainsNumber("1");
        }

        [TestMethod]
        public void ContainsNumber_a1_OkTest()
        {
            ClientValidator.ContainsNumber("a1");
        }

        [ExpectedException(typeof(NotContainsCapitalException))]
        [TestMethod]
        public void ContainsCapital_EmptyString_OkTest()
        {
            ClientValidator.ContainsCapital("");
        }

        [TestMethod]
        public void ContainsCapital_A_OkTest()
        {
            ClientValidator.ContainsCapital("A");
        }

        [TestMethod]
        public void ContainsCapital_aA_OkTest()
        {
            ClientValidator.ContainsCapital("aA");
        }

        [ExpectedException(typeof(NotInExpectedRangeException))]
        [TestMethod]
        public void LengthInRangePassword_EmptyString_OkTest()
        {
            ClientValidator.LengthInRangePassword("");
        }

        [TestMethod]
        public void LengthInRangePassword_ABCDE_OkTest()
        {
            ClientValidator.LengthInRangePassword("ABCDE");
        }

        [ExpectedException(typeof(NotInExpectedRangeException))]
        [TestMethod]
        public void LengthInRangePassword_ABCDEFGHIJKLMNOPQRSTUVWXYZ_OkTest()
        {
            ClientValidator.LengthInRangePassword("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }


    }
}
