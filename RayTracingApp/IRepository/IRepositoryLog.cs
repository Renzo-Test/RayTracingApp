using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryLog
	{
		List<Log> GetAllLogs();
		void AddLog(Log model, Client client);
	}
}
