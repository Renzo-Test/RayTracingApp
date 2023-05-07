using IRepository;
using Models;
using System.Collections.Generic;

namespace MemoryRepository
{
	public class ModelRepository : IRepositoryModel
	{
		private readonly List<Model> _models;

		public ModelRepository()
		{
			_models = new List<Model>();
		}
		public void AddModel(Model newModel)
		{
			_models.Add(newModel);
		}
		public List<Model> GetModelsByClient(string username)
		{
			List<Model> foundModels = _models.FindAll(model => model.Owner.Equals(username));
			return foundModels;
		}
		public void RemoveModel(Model model)
		{
			_models.Remove(model);
		}
	}
}
