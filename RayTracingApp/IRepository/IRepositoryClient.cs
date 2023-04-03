using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IRepository
{
    public interface IRepositoryClient
    {
        void AddClient(string username, string password);

        string GetPassword(string username);
    }
}
