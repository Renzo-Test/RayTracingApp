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
            return int.TryParse(password, out _);
        }
    }
}
