using Controller.Exceptions;
using System;
using System.Linq;

namespace Controller
{
    public static class ClientValidator
    {

        public static void IsValidUsername(string username)
        {
            IsAphanumeric(username); 
            LengthInRangeUsername(username);

        }

        public static void IsValidPassword(string password)
        {
            ContainsNumber(password);
            ContainsCapital(password);
            LengthInRangePassword(password);

        }

        public static void LengthInRangeUsername(string username)
        {
            if(!(username.Length >= 3 && username.Length <= 20))
            {
                throw new NotInExpectedRangeException("Username's length must be greater than 2 and smaller than 21");
            }
        }

        //alphanumeric includes non special characters and no spaces
        public static void IsAphanumeric(string username)
        {
            if (username.All(char.IsLetterOrDigit))
            {
                throw new NotAlphanumericException("Username must only include letters and numbers with no spaces");
            }
        }

        public static void ContainsNumber(string password)
        {
            if (!password.Any(char.IsDigit))
            {
                throw new NotContainsNumberException("Password must contain at least one number");
            }
        }

        public static void ContainsCapital(string password)
        {
            if (!password.Any(char.IsUpper))
            {
                throw new NotContainsCapitalException("Password must contain at least one capital letter");
            }
        }

        public static void LengthInRangePassword(string password)
        {
            if(!(password.Length >= 5 && password.Length <= 25))
            {
                throw new NotInExpectedRangeException("Password's length must be greater than 4 and smaller than 26");
            }
        }


    }
}
