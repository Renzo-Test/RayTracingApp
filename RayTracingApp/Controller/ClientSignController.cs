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
        private ClientPasswordController _passwordController;

        public ClientSignController()
        {
            _repo = base.Repository;
            _userController = new ClientUsernameController();
            _passwordController = new ClientPasswordController();
        }

        public bool SignUp(String username, String password)
        {
            return _userController.isValid(username) && _passwordController.CheckIfContainsCapital(password)
                && _passwordController.CheckIfContainsNumber(password) && _passwordController.CheckIfLengthInRange(password);
        }
    }
}
