using IRepository;
using MemoryRepository.Exceptions;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DBRepository
{
	public class ClientRepository : IRepositoryClient
	{
		public string DBName { get; set; } = "RayTracingAppDB";

		public void AddClient(string username, string password)
		{
			Client newClient = new Client()
			{
				Username = username,
				Password = password
			};
			using (var context = new AppContext(DBName))
			{
				context.Clients.Add(newClient);
				context.SaveChanges();
			}
		}

		public Client GetClient(string username)
		{
			using (var context = new AppContext(DBName))
			{
				Client foundClient = context.Clients.FirstOrDefault(client => client.Username.Equals(username));

				if (foundClient is null)
				{
					string NotFoundClientMessage = $"client with username {username} was not found";
					throw new NotFoundClientException(NotFoundClientMessage);
				}

				return foundClient;
			}
		}
	}
}
