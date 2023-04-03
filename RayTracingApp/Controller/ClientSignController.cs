using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientSignController : ClientController
    {
        private IRepositoryClient _repo;
        private ClientUsernameController _userController;

        public ClientSignController()
        {
            _repo = base.Repository;
            _userController = new ClientUsernameController();
        }

        public bool SignUp(String username, String password)
        {
            if (!_userController.isValid(username) || !ClientPasswordController.isValid(password))
                return false;
            return true;
        }


        public void SignOut() { }
    }
}
