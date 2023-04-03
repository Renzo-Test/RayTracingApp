using System.Collections.Generic;
using Model;
using IRepository;

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

        public string GetPassword(string username)
        {
            Client foundClient = _clientsList.Find(client => client.Username.Equals(username));

            return foundClient.Password;
        }
    }
}
