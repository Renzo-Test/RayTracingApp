using System;
using System.Linq;


namespace Controller
{
    public static class ClientPasswordController
    {
        public static bool CheckIfContainsNumber(string password)
        {
            return password.Any(char.IsDigit);  
        }

        public static bool CheckIfContainsCapital(string password)
        {
            return password.Any(char.IsUpper);
        }

        public static bool CheckIfLengthInRange(string password)
        {
            return password.Length >= 5 && password.Length <= 25;
        }

        public static bool IsValid(string password)
        {
            return CheckIfLengthInRange(password) && CheckIfContainsCapital(password)
                && CheckIfContainsNumber(password);
        }
    }
}
