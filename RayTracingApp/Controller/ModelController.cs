using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;
using MemoryRepository;
using MemoryRepository.MaterialRepository;
using Models;
using Controller.ModelExceptions;
using MemoryRepository.Exceptions;

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
        public void AddModel(Model model, string username)
        {
            try
            {
                RunModelChecker(model, username);
                model.Owner = username;
                Repository.AddModel(model);
            } 
            catch (InvalidModelInputException ex) 
            {
                throw new InvalidModelInputException(ex.Message);
            }
        }
        private void RunModelChecker(Model model, string username)
        {
            if (ModelNameExist(model,username))
            {
                string AlreadyExistingModelName = $"Model with name {model.Name} already exist";
                throw new AlreadyExistingModelException(AlreadyExistingModelName);
            }
        }

        private bool ModelNameExist(Model model, string username) 
        {
            try
            {
                List<Model> clientModels = Repository.GetModelsByClient(username);
                return clientModels.Find(mod => mod.Name.Equals(model.Name)) is object;
            } 
            catch (NotFoundModelException)
            {
                return false;
            }
        }

    }
}
