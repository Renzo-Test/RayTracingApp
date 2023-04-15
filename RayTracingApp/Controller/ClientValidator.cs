using Controller.Exceptions;
using System;
using System.Linq;

namespace Controller
{
    public static class ClientValidator
    {
        private const string NotAlphanumericMessage = "Username must only include letters and numbers with no spaces";
        private const string NotContainsNumberMessage = "Password must contain at least one number";
        private const string NotContainsCapitalMessage = "Password must contain at least one capital letter";
        private const string NotInExpectedRangeUsernameMessage = "Username's length must be greater than 2 and smaller than 21";
        private const string NotInExpectedRangePasswordMessage = "Password's length must be greater than 4 and smaller than 26";

        public static void RunUsernameConditions(string username)
        {
            IsAphanumeric(username); 
            LengthInRangeUsername(username);

        }

        public static void RunPasswordConditions(string password)
        {
            ContainsNumber(password);
            ContainsCapital(password);
            LengthInRangePassword(password);

        }

        public static void LengthInRangeUsername(string username)
        {
            if(!(username.Length >= 3 && username.Length <= 20))
            {
                throw new NotInExpectedRangeException(NotInExpectedRangeUsernameMessage);
            }
        }

        //alphanumeric includes non special characters and no spaces
        public static void IsAphanumeric(string username)
        {
            if (!username.All(char.IsLetterOrDigit))
            {
                throw new NotAlphanumericException(NotAlphanumericMessage);
            }
        }

        public static void ContainsNumber(string password)
        {
            if (!password.Any(char.IsDigit))
            {
                throw new NotContainsNumberException(NotContainsNumberMessage);
            }
        }

        public static void ContainsCapital(string password)
        {
            if (!password.Any(char.IsUpper))
            {
                throw new NotContainsCapitalException(NotContainsCapitalMessage);
            }
        }

        public static void LengthInRangePassword(string password)
        {
            if(!(password.Length >= 5 && password.Length <= 25))
            {
                throw new NotInExpectedRangeException(NotInExpectedRangePasswordMessage);
            }
        }


    }
}
