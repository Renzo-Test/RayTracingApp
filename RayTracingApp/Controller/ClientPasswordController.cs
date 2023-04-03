using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class ClientPasswordController
    {
        public static bool CheckIfContainsNumber(String password)
        {
            return password.Any(char.IsDigit);  
        }

        public static bool CheckIfContainsCapital(String password)
        {
            return password.Any(char.IsUpper);
        }

        public static bool CheckIfLengthInRange(string password)
        {
            return password.Length >= 5 && password.Length <= 25;
        }

        public static bool IsValid(String password)
        {
            return CheckIfLengthInRange(password) && CheckIfContainsCapital(password)
                && CheckIfContainsNumber(password);
        }
    }
}
