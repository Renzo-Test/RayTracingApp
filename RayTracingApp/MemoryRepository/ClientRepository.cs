using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IRepository;
using MemoryRepository.Exceptions;

namespace MemoryRepository
{
    public class ClientRepository
    {
        private List<Client> _clientsList;

        public ClientRepository()
        {
            _clientsList = new List<Client>();
        }

        public void addClient(Client newClient)
        {
            _clientsList.Add(newClient);
        }

        public string getPassword(string username)
        {
            if (username.Equals("")) throw new ExceptionGetPasswordOfEmptyUsername();

            return _clientsList.Find(x => x.Username.Equals(username)).Password;
        }
    }
}
