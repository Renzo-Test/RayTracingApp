using Controller.Exceptions;
using IRepository;
using MemoryRepository;
using Model;
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
        
        public void CheckIfClientExists(string username)
        {
            if (Repository.GetClient(username) is object)
            {
                string AlreadyExsitingClientMessage = $"Client with username {username} already exists";
                throw new AlreadyExistingClientException(AlreadyExsitingClientMessage);
            };
        }

        public void SignUp(string username, string password)
        {
            try
            {
                RunConditionsChecker(username, password);
                Repository.AddClient(username, password);
            }
            catch (InvalidCredentialsException ex)
            {
                throw new InvalidCredentialsException(ex.Message);
            }
        }

        private void RunConditionsChecker(string username, string password)
        {
           CheckIfClientExists(username);
           ClientValidator.RunPasswordConditions(password);
           ClientValidator.RunUsernameConditions(username);
        }

        public void SignOut(ref Client currentClient) 
        {
            currentClient = null;
        }

        public Client SignIn(string username, string password)
        {
            if (CredentialsAreInvalid(username, password))
                return null;

            return Repository.GetClient(username);

        }

        private bool CredentialsAreInvalid(string username, string password)
        {
            //return !CheckIfClientExists(username) || !Repository.GetClient(username).Password.Equals(password);
            return false;
        }

        public bool IsLoggedIn(Client currentClient)
        {
            return currentClient is object;
        }
    }
}
