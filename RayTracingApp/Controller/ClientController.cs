using Controller.Exceptions;
using IRepository;
using MemoryRepository;
using Model;
using System;


namespace Controller
{
    public class ClientController
    {
        private const string WrongPasswordMessage = "Wrong email or password";
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
            try
            {
                RunSignInChekcer(username, password);
                return Repository.GetClient(username);
            }
            catch (InvalidCredentialsException ex)
            {
                throw new InvalidCredentialsException(ex.Message);
            }

        }

        private void RunSignInChekcer(string username, string password)
        {
            try
            {
                if (!Repository.GetClient(username).Password.Equals(password))
                {
                    throw new NotCorrectPasswordException(WrongPasswordMessage);
                }
            }
            catch (NullReferenceException)
            {
                throw new NotCorrectPasswordException(WrongPasswordMessage);
            }
        }


        public bool IsLoggedIn(Client currentClient)
        {
            return currentClient is object;
        }
    }
}
