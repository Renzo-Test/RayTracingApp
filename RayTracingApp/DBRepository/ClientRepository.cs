using IRepository;
using DBRepository.Exceptions;
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

		public void SaveDefaultCameraAtributes(Client client)
		{
			using (var context = new AppContext(DBName))
			{
				Client updateClient = context.Clients.FirstOrDefault(c => c.Username.Equals(client.Username));
				updateClient.DefaultFov = client.DefaultFov;
				updateClient.DefaultLookFrom = client.DefaultLookFrom;
				updateClient.DefaultLookAt = client.DefaultLookAt;
				context.SaveChanges();
			}
		}

		public void SaveDefaultRenderProperties(Client client, RenderProperties renderProperties)
		{
			client.DefaultRenderProperties = renderProperties;
			using (var context = new AppContext(DBName))
			{
				Client updateClient = context.Clients.FirstOrDefault(c => c.Username.Equals(client.Username));
				updateClient.DefaultRenderProperties = renderProperties;
				context.SaveChanges();
			}
		}
	}
}
