using Controller.Exceptions;
using IRepository;
using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Domain.Exceptions;

namespace Controller
{
	public class ClientController
	{
		private const string WrongPasswordMessage = "Wrong email or password";

		private const string DefaultDatabase = "RayTracingAppDB";

		public IRepositoryClient Repository;
		public ClientController(string dbName = DefaultDatabase)
		{
			Repository = new ClientRepository()
			{
				DBName = dbName,
			};
		}

		public void SignUp(string username, string password)
		{
			try
			{
				RunSignUpChecker(username, password);
				Repository.AddClient(username, password);
			}
			catch (InvalidCredentialsException ex)
			{
				throw new InvalidCredentialsException(ex.Message);
			}
		}

		public bool ClientAlreadyExists(string username)
		{
			try
			{
				Repository.GetClient(username);
				return true;
			}
			catch (NotFoundClientException)
			{
				return false;
			};
		}

		public Client SignIn(string username, string password)
		{
			try
			{
				RunSignInChecker(username, password);
				return Repository.GetClient(username);
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

		private void RunSignUpChecker(string username, string password)
		{
			if (ClientAlreadyExists(username))
			{
				string AlreadyExsitingClientMessage = $"Client with username {username} already exists";
				throw new AlreadyExistingClientException(AlreadyExsitingClientMessage);
			}
		}

		private void RunSignInChecker(string username, string password)
		{
			try
			{
				string _clientPassword = Repository.GetClient(username).Password;

				if (!_clientPassword.Equals(password))
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
