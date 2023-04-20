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
            ClientValidator.RunUsernameConditions("");
        }

        [TestMethod]
        public void LengthInRangeUsername_ABC_OkTest()
        {
            ClientValidator.RunUsernameConditions("ABC");
        }

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangeUsername_ABCDEFGHIJKLMNOPQRSTU_FailTest()
        {
            ClientValidator.RunUsernameConditions("ABCDEFGHIJKLMNOPQRSTU");
        }

        [TestMethod]
        public void Alphanumeric_EmptyString_OkTest()
        {
            ClientValidator.RunUsernameConditions("ab1");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_QuestionMark_FailTest()
        {
            ClientValidator.RunUsernameConditions("?");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_AQuestionMarkB_FailTest()
        {
            ClientValidator.RunUsernameConditions("A?B");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_SpaceAB_FailTest()
        {
            ClientValidator.RunUsernameConditions(" AB");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_ASpaceB_FailTest()
        {
            ClientValidator.RunUsernameConditions("A B");
        }

        [TestMethod]
        [ExpectedException(typeof(NotAlphanumericException))]
        public void Alphanumeric_ABSpace_FailTest()
        {
            ClientValidator.RunUsernameConditions("AB ");
        }

        [TestMethod]
        [ExpectedException(typeof(NotContainsNumberException))]
        public void ContainsNumber_EmptyString_FailTest()
        {
            ClientValidator.RunPasswordConditions("");
        }

        [TestMethod]
        public void ContainsNumber_1_OkTest()
        {
            ClientValidator.RunPasswordConditions("1");
        }

        [TestMethod]
        public void ContainsNumber_a1_OkTest()
        {
            ClientValidator.RunPasswordConditions("a1");
        }

        [TestMethod]
        [ExpectedException(typeof(NotContainsCapitalException))]
        public void ContainsCapital_EmptyString_FailTest()
        {
            ClientValidator.RunPasswordConditions("");
        }

        [TestMethod]
        public void ContainsCapital_A_OkTest()
        {
            ClientValidator.RunPasswordConditions("A");
        }

        [TestMethod]
        public void ContainsCapital_aA_OkTest()
        {
            ClientValidator.RunPasswordConditions("aA");
        }

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangePassword_EmptyString_FailTest()
        {
            ClientValidator.RunPasswordConditions("");
        }

        [TestMethod]
        public void LengthInRangePassword_ABCDE_OkTest()
        {
            ClientValidator.RunPasswordConditions("ABCDE");
        }

        [TestMethod]
        [ExpectedException(typeof(NotInExpectedRangeException))]
        public void LengthInRangePassword_ABCDEFGHIJKLMNOPQRSTUVWXYZ_FailTest()
        {
            ClientValidator.RunPasswordConditions("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }


    }
}
