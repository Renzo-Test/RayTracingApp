using System.Collections.Generic;
using Model;
using IRepository;
using System;

namespace MemoryRepository
{
    public class ClientRepository : IRepositoryClient
    {
        private readonly List<Client> _clientsList;

        public ClientRepository()
        {
            _clientsList = new List<Client>();
        }

        public void AddClient(string username, string password)
        {
            Client newClient = new Client()
            {
                Username = username,
                Password = password,
            };

            _clientsList.Add(newClient);
        }

        public Client GetClient(string username)
        {
            return _clientsList.Find(client => client.Username.Equals(username));
        }

        public string GetPassword(string username)
        {
            Client foundClient = _clientsList.Find(client => client.Username.Equals(username));

            return foundClient.Password;
        }
    }
}
