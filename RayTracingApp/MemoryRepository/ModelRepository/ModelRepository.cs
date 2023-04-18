using IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository
{
    public class ModelRepository
    {
        private readonly List<Model> _models;

        public ModelRepository()
        {
            _models = new List<Model>();
        }
        public void AddModel(Model newModel)
        {
        }
        public List<Model> GetModelsByClient(string username) 
        {
            List<Model> foundModels = _models.FindAll(model => model.Owner.Equals(username));
            return foundModels;
        }
    }
}
