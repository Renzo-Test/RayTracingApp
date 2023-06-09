using DBRepository;
using Domain.Exceptions;
using Domain;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LogController
    {
        private const string DefaultDatabase = "RayTracingAppDB";
        public IRepositoryLog Repository;

        public LogController(string dbName = DefaultDatabase)
        {
            Repository = new LogRepository()
            {
                DBName = dbName,
            };
        }
        public void AddLog(Log newLog)
        {
            Repository.AddLog(newLog);
        }
        public List<Log> ListLogs()
        {
            return Repository.GetAllLogs();
        }

        public int GetAverageRenderTime()
        {
            int totalRenderLogs = Repository.GetAllLogs().Count();
            if (totalRenderLogs == 0)
                return 0;

            int totalTime = 0;
            foreach (var log in Repository.GetAllLogs())
            {
                totalTime += log.RenderTime;
            }

            return totalTime / totalRenderLogs;
        }

    }
}
