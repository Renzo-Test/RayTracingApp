using IRepository;
using MemoryRepository;
using System;


namespace Controller
{
    public class ClientController
    {
        public IRepositoryClient Repository;
        public ClientController()
        {
            Repository = new ClientRepository();
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
                   && ClientPasswordController.IsValid(password)
                   && ClientUsernameController.IsValid(username);
        }

        public void SignOut() 
        {
            CurrentClient.Username = string.Empty;
        }

        public bool SignIn(string username, string password)
        {
            if (CredentialsAreInvalid(username, password))
                return false;

            CurrentClient.Username = username;
            return true;

        }

        private bool CredentialsAreInvalid(string username, string password)
        {
            return !CheckIfClientExists(username) || !Repository.GetClient(username).Password.Equals(password);
        }
    }
}
