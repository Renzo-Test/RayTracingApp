using System;
using IRepository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DBRepository
{
    public class LogRepository : IRepositoryLog
    {
        public string DBName { get; set; } = "RayTracingAppDB";

        public void AddLog(Log log)
        {
            using (var context = new AppContext(DBName))
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

        public List<Log> GetAllLogs()
        {
            using (var context = new AppContext(DBName))
            {
                return context.Logs.ToList();
            }
        }
    }
}
