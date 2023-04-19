using Controller;
using Controller.ClientExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test.ControllerTest
{
    [TestClass]

    public class ClientValidatorTest
    {

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangeUsername_EmptyString_FailTest()
        {
            ClientValidator.LengthInRangeUsername("");
        }

        [TestMethod]
        public void LengthInRangeUsername_ABC_OkTest()
        {
            ClientValidator.LengthInRangeUsername("ABC");
        }

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangeUsername_ABCDEFGHIJKLMNOPQRSTU_FailTest()
        {
            ClientValidator.LengthInRangeUsername("ABCDEFGHIJKLMNOPQRSTU");
        }

        [TestMethod]
        public void Alphanumeric_EmptyString_OkTest()
        {
            ClientValidator.IsAphanumeric("");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_QuestionMark_FailTest()
        {
            ClientValidator.IsAphanumeric("?");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_AQuestionMarkB_FailTest()
        {
            ClientValidator.IsAphanumeric("A?B");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_SpaceAB_FailTest()
        {
            ClientValidator.IsAphanumeric(" AB");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_ASpaceB_FailTest()
        {
            ClientValidator.IsAphanumeric("A B");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_ABSpace_FailTest()
        {
            ClientValidator.IsAphanumeric("AB ");
        }

        [TestMethod]
        [ExpectedException(typeof(NotContainsNumberException))]
        public void ContainsNumber_EmptyString_FailTest()
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

        [TestMethod]
        [ExpectedException(typeof(NotContainsCapitalException))]
        public void ContainsCapital_EmptyString_FailTest()
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

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangePassword_EmptyString_FailTest()
        {
            ClientValidator.LengthInRangePassword("");
        }

        [TestMethod]
        public void LengthInRangePassword_ABCDE_OkTest()
        {
            ClientValidator.LengthInRangePassword("ABCDE");
        }

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangePassword_ABCDEFGHIJKLMNOPQRSTUVWXYZ_FailTest()
        {
            ClientValidator.LengthInRangePassword("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }


    }
}
