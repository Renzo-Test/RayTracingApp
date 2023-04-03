using IRepository;
using MemoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public abstract class ClientController
    {
        public IRepositoryClient Repository = new ClientRepository();

        /*
        public bool CheckIfClientExists(String username)
        {
            try
            {
                _repo.GetPassword(username);
                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }
         */
    }
}
