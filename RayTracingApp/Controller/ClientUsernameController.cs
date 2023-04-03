using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientUsernameController : ClientController
    {
        
        public bool CheckIfClientExists(string username)
        {
            return false;
        }
    }
}
