using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientPasswordController : ClientController
    {
        public bool CheckIfContainsNumber(String password)
        {
            if (password.Length == 0)
                return false;
            if (password.Length == 1)
                return int.TryParse(password, out _);
            return int.TryParse(password[0].ToString(), out _) || int.TryParse(password[1].ToString(), out _);
        }
    }
}
