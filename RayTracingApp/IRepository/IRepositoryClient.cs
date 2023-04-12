using Model;
using System;

namespace IRepository
{
    public interface IRepositoryClient
    {
        void AddClient(string username, string password);

        Client GetClient(string username);
    }
}
