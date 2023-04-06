using IRepository;
using MemoryRepository;
using System;


namespace Controller
{
    public class ClientController
    {
        public IRepositoryClient Repository;
        public CurrentClient CurrentClient;
        public ClientController(CurrentClient currentClient)
        {
            CurrentClient = currentClient;
            Repository = new ClientRepository();
        }
        
        public bool CheckIfClientExists(string username)
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

        public void SignOut() { }

        public bool SignIn(string username, string password)
        {
            if (!CheckIfClientExists(username))
                return false;

            if (Repository.GetPassword(username).Equals(password))
            {
                CurrentClient.Username = username;
                return true;
            }

            return false;
        }
    }
}
