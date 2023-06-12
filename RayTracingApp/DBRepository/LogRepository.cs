using Domain;
using IRepository;
using System.Collections.Generic;
using System.Linq;

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
