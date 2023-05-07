using Models;

namespace IRepository
{
	public interface IRepositoryClient
	{
		void AddClient(string username, string password);

		Client GetClient(string username);
	}
}
