using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;
using MemoryRepository;
using MemoryRepository.MaterialRepository;
using Models;

namespace Controller
{
    public class ModelController
    {
        public IRepositoryModel Repository;

        public ModelController()
        {
            Repository = new ModelRepository();
        }

        public List<Model> ListModels(string username)
        {
            return Repository.GetModelsByClient(username);
        }
    }
}
