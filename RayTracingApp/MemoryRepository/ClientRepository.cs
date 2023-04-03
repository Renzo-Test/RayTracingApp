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
    public class ClientRepository : IRepositoryClient
    {
        private List<Client> _clientsList;

        public ClientRepository()
        {
            _clientsList = new List<Client>();
        }

        public void AddClient(Client newClient)
        {
            _clientsList.Add(newClient);
        }

        public string GetPassword(string username)
        {
            Client foundClient = _clientsList.Find(client => client.Username.Equals(username));

            return foundClient.Password;
        }
    }
}
