using DBRepository;
using Domain;
using IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
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

		public Client GetUserWithMaxAccumulatedRenderTime()
		{
			List<Log> logs = Repository.GetAllLogs();

			var userMaxRenderTime = logs
				.GroupBy(log => log.Owner)
				.Select(group => new
				{
					Owner = group.Key,
					AccumulatedRenderTime = group.Sum(log => log.RenderTime)
				})
				.OrderByDescending(group => group.AccumulatedRenderTime)
				.FirstOrDefault();

			if (userMaxRenderTime is object)
			{
				return userMaxRenderTime.Owner;
			}

			return null;
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

        public string GetRenderTimeWindow(string sceneName, List<Log> logs)
        {
            Log previousLog = logs
                .Where(log => log.SceneName == sceneName)
                .OrderByDescending(log => log.RenderDate)
                .FirstOrDefault();

            if (previousLog != null)
            {
                DateTime previousRenderDate = DateTime.Parse(previousLog.RenderDate);
                DateTime currentRenderDate = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan timeWindow = currentRenderDate - previousRenderDate;

                if (previousLog.SceneName.StartsWith("preview"))
                {
                    return "0 segundos";
                }
                if (timeWindow.TotalSeconds < 60)
                {
                    return $"{Math.Floor(timeWindow.TotalSeconds)} segundos";
                }
                if (timeWindow.TotalMinutes < 60)
                {
                    return $"{Math.Floor(timeWindow.TotalMinutes)} minutos";
                }
                if (timeWindow.TotalHours < 24)
                {
                    return $"{Math.Floor(timeWindow.TotalHours)} horas";
                }
                    return $"{Math.Floor(timeWindow.TotalDays)} días";
            }

            return "0 segundos";
        }

    }
}

