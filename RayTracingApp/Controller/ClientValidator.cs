using System;
using System.Linq;

namespace Controller
{
    public static class ClientValidator
    {

        public static bool IsValidUsername(string username)
        {
            return IsAphanumeric(username) && LengthInRangeUsername(username);
        }

        public static bool IsValidPassword(string password)
        {
            return LengthInRangePassword(password) && ContainsCapital(password)
                && ContainsNumber(password);
        }

        public static bool LengthInRangeUsername(string username)
        {
            return username.Length >= 3 && username.Length <= 20;
        }

        //alphanumeric includes non special characters and no spaces
        public static bool IsAphanumeric(string username)
        {
            return username.All(char.IsLetterOrDigit);
        }

        public static bool ContainsNumber(string password)
        {
            return password.Any(char.IsDigit);
        }

        public static bool ContainsCapital(string password)
        {
            return password.Any(char.IsUpper);
        }

        public static bool LengthInRangePassword(string password)
        {
            return password.Length >= 5 && password.Length <= 25;
        }


    }
}
