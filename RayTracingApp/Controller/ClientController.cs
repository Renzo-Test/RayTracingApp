using Controller.Exceptions;
using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Domain.Exceptions;
using IRepository;

namespace Controller
{
	public class ClientController
	{
		private const string WrongPasswordMessage = "Wrong email or password";

		public IRepositoryClient Repository;

		private const string DefaultDatabase = "RayTracingAppDB";
		public ClientController(string dbName = DefaultDatabase)
		{
			Repository = new ClientRepository()
			{
				DBName = dbName,
			};
		}

		public void SignUp(Client client)
		{
			try
			{
				RunSignUpChecker(client);
				Repository.AddClient(client.Username, client.Password);
			}
			catch (InvalidCredentialsException ex)
			{
				throw new InvalidCredentialsException(ex.Message);
			}
		}

		public Client SignIn(Client client)
		{
			try
			{
				RunSignInChecker(client.Username, client.Password);
				return Repository.GetClient(client.Username);
			}
			catch (InvalidCredentialsException ex)
			{
				throw new InvalidCredentialsException(ex.Message);
			}
		}
		public void SignOut(ref Client currentClient)
		{
			currentClient = null;
		}

		public bool ClientAlreadyExists(Client client)
		{
			try
			{
				Repository.GetClient(client.Username);
				return true;
			}
			catch (NotFoundClientException)
			{
				return false;
			};
		}

		public bool IsLoggedIn(Client currentClient)
		{
			return currentClient is object;
		}

		public void SaveDefaultCameraAtributes(Client client)
		{
			Repository.SaveDefaultCameraAtributes(client);
		}

		public void SaveDefaultRenderProperties(Client client, RenderProperties renderProperties)
		{
			Repository.SaveDefaultRenderProperties(client, renderProperties);
		}

		private void RunSignUpChecker(Client client)
		{
			if (ClientAlreadyExists(client))
			{
				string AlreadyExsitingClientMessage = $"Client with username {client.Username} already exists";
				throw new AlreadyExistingClientException(AlreadyExsitingClientMessage);
			}
		}

		private void RunSignInChecker(Client client)
		{
			try
			{
				string _clientPassword = Repository.GetClient(client.Username).Password;

				if (!_clientPassword.Equals(client.Password))
				{
					throw new NotCorrectPasswordException(WrongPasswordMessage);
				}
			}
			catch (NotFoundClientException)
			{
				throw new NotCorrectPasswordException(WrongPasswordMessage);
			}
		}
	}
}
