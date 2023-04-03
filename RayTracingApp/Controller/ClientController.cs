using IRepository;
using MemoryRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientController
    {
        public IRepositoryClient Repository = new ClientRepository();
        
        public bool CheckIfClientExists(String username)
        {
            try
            {
                Repository.GetPassword(username);
                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }

        public bool SignUp(String username, String password)
        {
            if (!ClientUsernameController.isValid(username) || !ClientPasswordController.isValid(password)
                || CheckIfClientExists(username))
                return false;
            
            Client newClient = new Client()
            {
                Username = username,
                Password = password,
            };

            Repository.AddClient(newClient);
            return true;
        }


        public void SignOut() { }
    }
}
