using System;
using System.Linq;

namespace Controller
{
    public static class ClientUsernameController 
    {

        public static bool CheckIfLengthInRange(string username)
        {
            return username.Length >= 3 && username.Length <= 20;
        }

        //alphanumeric includes non special characters and no spaces 
        public static bool CheckIfAlphanumeric(string username)
        {
            return username.All(char.IsLetterOrDigit);
        }

        public static bool IsValid(string username)
        {
            return CheckIfAlphanumeric(username) && CheckIfLengthInRange(username);
        }
    }
}
