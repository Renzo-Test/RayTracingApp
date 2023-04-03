using IRepository;
using MemoryRepository;
using System;


namespace Controller
{
    public class ClientController
    {
        public IRepositoryClient Repository = new ClientRepository();
        
        public bool CheckIfClientExists(String username)
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

        public bool SignUp(String username, String password)
        {
            if (IsInputOk(username, password))
                return false;

            Repository.AddClient(username, password);
            return true;
        }

        private bool IsInputOk(string username, string password)
        {
            return CheckIfClientExists(username)
                   || !ClientPasswordController.IsValid(password)
                   || !ClientUsernameController.IsValid(username);
        }

        public void SignOut() { }

        public bool SignIn(string username, string password)
        {
            if (!CheckIfClientExists(username))
                return false;
            return Repository.GetPassword(username).Equals(password);
        }
    }
}
