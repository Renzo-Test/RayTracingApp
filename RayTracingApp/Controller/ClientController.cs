using IRepository;
using MemoryRepository;
using Model;
using System;


namespace Controller
{
    public class ClientController
    {
        public IRepositoryClient Repository;
        private Client _reservedClient;
        public ClientController()
        {
            Repository = new ClientRepository();
            _reservedClient = new Client()
            {
                Username = "NotSignedInClient",
            };
        }
        
        public bool CheckIfClientExists(string username)
        {
            return Repository.GetClient(username) is object;
        }

        public bool SignUp(string username, string password)
        {
            if (!IsInputOk(username, password))
                return false;

            Repository.AddClient(username, password);
            return true;
        }

        private bool IsInputOk(string username, string password)
        {
            return !CheckIfClientExists(username)
                   && ClientValidator.IsValidPassword(password)
                   && ClientValidator.IsValidUsername(username);
        }

        public void SignOut(ref Client currentClient) 
        {
            currentClient = _reservedClient;
        }

        public Client SignIn(string username, string password)
        {
            if (CredentialsAreInvalid(username, password))
                return null;

            return Repository.GetClient(username);

        }

        private bool CredentialsAreInvalid(string username, string password)
        {
            return !CheckIfClientExists(username) || !Repository.GetClient(username).Password.Equals(password);
        }

        public bool IsLoggedIn(Client currentClient)
        {
            return !currentClient.Equals(_reservedClient);
        }
    }
}
