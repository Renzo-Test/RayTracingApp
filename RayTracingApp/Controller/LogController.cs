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

          return userMaxRenderTime.Owner;
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

        public string GetRenderTimeWindow(string sceneName, List<Log> logs, string currentRenderDate)
        {
            Log previousLog = logs.Where(log => log.SceneName == sceneName)
                         .OrderByDescending(log => log.RenderDate)
                         .ToList().FirstOrDefault();

            if (previousLog == null)
            {
                return "0 seconds";
            }

            DateTime currentDateTime = DateTime.Parse(currentRenderDate);
            DateTime previousDateTime = DateTime.Parse(previousLog.RenderDate);

            TimeSpan timeDifference = currentDateTime - previousDateTime;

            if (timeDifference.TotalSeconds < 60)
            {
                return $"{Math.Floor(timeDifference.TotalSeconds)} seconds";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{Math.Floor(timeDifference.TotalMinutes)} minutes";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{Math.Floor(timeDifference.TotalHours)} hours";
            }
            else
            {
                return $"{Math.Floor(timeDifference.TotalDays)} days";
            }
        }
    }
}

