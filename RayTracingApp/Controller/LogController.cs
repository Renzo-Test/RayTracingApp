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


        public (string, int) GetUserWithMaxAccumulatedRenderTime()
        {
            List<Log> logs = Repository.GetAllLogs();
        
            var userMaxRenderTime = logs
                .GroupBy(log => log.Owner)
                .Select(group => new
                {
                  Owner = group.Key,
                  AccumulatedRenderTime = group.Sum(log => log.RenderTime),
                })
                .OrderByDescending(group => group.AccumulatedRenderTime)
                .FirstOrDefault();

            return (userMaxRenderTime.Owner.Username, userMaxRenderTime.AccumulatedRenderTime);
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
            Log previousLog = logs.Where(log => log.SceneName == sceneName)
                         .OrderByDescending(log => log.RenderDate)
                         .ToList().FirstOrDefault();

            if (previousLog is null)
            {
                return "0 seconds";
            }

            DateTime currentDateTime = DateTime.Now;
            DateTime previousDateTime = DateTime.Parse(previousLog.RenderDate);

            TimeSpan timeDifference = currentDateTime - previousDateTime;

            if (timeDifference.TotalSeconds < 60)
            {
                return $"{Math.Floor(timeDifference.TotalSeconds)} seconds";
            }
            
            if (timeDifference.TotalMinutes < 60)
            {
                return $"{Math.Floor(timeDifference.TotalMinutes)} minutes";
            }
            
            if (timeDifference.TotalHours < 24)
            {
                return $"{Math.Floor(timeDifference.TotalHours)} hours";
            }
     
            return $"{Math.Floor(timeDifference.TotalDays)} days";
        }
    }
}

