using System.Collections.Generic;
using Model;
using IRepository;
using System;

namespace MemoryRepository
{
    public class ClientRepository : IRepositoryClient
    {
        private readonly List<Client> _clients;

        public ClientRepository()
        {
            _clients = new List<Client>();
        }

        public void AddClient(string username, string password)
        {
            Client newClient = new Client()
            {
                Username = username,
                Password = password,
            };

            _clients.Add(newClient);
        }

        public Client GetClient(string username)
        {
            Client foundClient = _clients.Find(client => client.Username.Equals(username));

            return foundClient;
        }
    }
}
