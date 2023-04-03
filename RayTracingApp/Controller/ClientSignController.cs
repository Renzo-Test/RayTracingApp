using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientSignController : ClientController
    {
        private ClientUsernameController _userController;

        public ClientSignController()
        {
            _userController = new ClientUsernameController();
        }

        public bool SignUp(String username, String password)
        {
            return _userController.CheckIfAlphanumeric(username) && _userController.CheckIfLengthInRange(username);
        }
    }
}
