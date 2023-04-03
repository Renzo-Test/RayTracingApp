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

        public ClientSignController()
        {
            _repo = base.Repository;

        }

        public bool SignUp(String username, String password)
        {
            if (!ClientUsernameController.isValid(username) || !ClientPasswordController.isValid(password))
                return false;
            return true;
        }


        public void SignOut() { }
    }
}
