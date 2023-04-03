using System;

namespace IRepository
{
    public interface IRepositoryClient
    {
        void AddClient(string username, string password);

        string GetPassword(string username);
    }
}
