using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryLog
	{
		List<Log> GetAllLogs();
		List<Log> GetLogsByClient(Client client);
		void AddLog(Log model, Client client);
	}
}
