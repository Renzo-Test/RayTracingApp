using IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _models.FindAll(model => model.Owner.Equals("Username"));
        }

        public void RemoveModel(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
