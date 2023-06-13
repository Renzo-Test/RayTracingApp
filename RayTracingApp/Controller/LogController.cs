using DBRepository;
using Domain;
using IRepository;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
	public class LogController
	{
		public IRepositoryLog Repository;

		private const string DefaultDatabase = "RayTracingAppDB";

		public LogController(string dbName = DefaultDatabase)
		{
			Repository = new LogRepository()
			{
				DBName = dbName,
			};
		}

		public void AddLog(Log newLog, Client client)
		{
			Repository.AddLog(newLog, client);
		}

		public List<Log> ListLogs()
		{
			return Repository.GetAllLogs();
		}

		public string GetUserWithMaxAccumulatedRenderTime()
		{
			List<Log> logs = Repository.GetAllLogs();

			var userMaxRenderTime = logs
				.GroupBy(log => log.Owner.Username)
				.Select(group => new
				{
					Username = group.Key,
					AccumulatedRenderTime = group.Sum(log => log.RenderTime)
				})
				.OrderByDescending(group => group.AccumulatedRenderTime)
				.FirstOrDefault();

			if (userMaxRenderTime is object)
			{
				return userMaxRenderTime.Username;
			}

			return string.Empty;
		}

		public int GetTotalRenderTimeInMinutes()
		{
			List<Log> logs = Repository.GetAllLogs();
			int totalRenderTime = logs.Sum(log => log.RenderTime);

			// Seconds to minutes
			return totalRenderTime / 60;
		}

		public int GetAverageRenderTimeInSeconds()
		{
			List<Log> logs = Repository.GetAllLogs();
			int totalRenderTime = logs.Sum(log => log.RenderTime);
			int totalLogs = logs.Count;

			if (totalLogs > 0)
			{
				return totalRenderTime / totalLogs;
			}

			return 0;
		}
	}
}

