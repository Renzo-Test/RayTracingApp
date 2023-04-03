using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class ClientUsernameController 
    {

        public static bool CheckIfLengthInRange(String username)
        {
            return username.Length >= 3 && username.Length <= 20;
        }

        //alphanumeric includes non special characters and no spaces 
        public static bool CheckIfAlphanumeric(String username)
        {
            return username.All(char.IsLetterOrDigit);
        }

        public static bool IsValid(String username)
        {
            return CheckIfAlphanumeric(username) && CheckIfLengthInRange(username);
        }
    }
}
