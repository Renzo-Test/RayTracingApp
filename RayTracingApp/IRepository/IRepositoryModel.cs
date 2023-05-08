using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryModel
	{
		List<Model> GetModelsByClient(string username);
		void AddModel(Model model);
		void RemoveModel(Model model);
	}
}
