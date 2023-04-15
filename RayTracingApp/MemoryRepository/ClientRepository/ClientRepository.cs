using System.Collections.Generic;
using Model;
using IRepository;
using System;
using MemoryRepository.Exceptions;

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

            if(foundClient is null)
            {
                string NotFoundClientMessage = $"client with username {username} was not found";
                throw new NotFoundClientException(NotFoundClientMessage);
            }

            return foundClient;
        }
    }
}
