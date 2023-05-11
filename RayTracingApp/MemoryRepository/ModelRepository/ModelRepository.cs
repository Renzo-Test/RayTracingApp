using IRepository;
using Domain;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

namespace MemoryRepository
{
    public class ModelRepository : IRepositoryModel
    {
        private const string NotFoundModelMessage = "Model was not found or already deleted";
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
            if (!_models.Remove(model))
            {
                throw new NotFoundModelException(NotFoundModelMessage);
            }
            else
            {
                _models.Remove(model);
            }

        }
    }
}
