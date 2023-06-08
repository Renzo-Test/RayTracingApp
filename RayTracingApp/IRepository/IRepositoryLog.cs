using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepositoryLog
    {
        List<Log> GetLogsByClient(string username);
        void AddLog(Log model);
    }
}
