﻿using DBRepository;
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
        public string GetUserWithMaxAccumulatedRenderTime()
        {
            List<Log> logs = Repository.GetAllLogs();

            var userMaxRenderTime = logs
                .GroupBy(log => log.Username)
                .Select(group => new
                {
                    Username = group.Key,
                    AccumulatedRenderTime = group.Sum(log => log.RenderTime)
                })
                .OrderByDescending(group => group.AccumulatedRenderTime)
                .FirstOrDefault();

            if (userMaxRenderTime != null)
            {
                return userMaxRenderTime.Username;
            }

            return string.Empty;
        }
        public int GetTotalRenderTimeInMinutes()
        {
            List<Log> logs = Repository.GetAllLogs();
            int totalRenderTime = logs.Sum(log => log.RenderTime);

            // Convertir de segundos a minutos
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

